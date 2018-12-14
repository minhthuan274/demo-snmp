using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SnmpSharpNet;
using System.Collections;
using System.Threading;

namespace SNMP
{
    public partial class Form1 : Form
    {
        private Toast toast;
        private int miThreadState = 1;
        private Queue mgResponseQueue = null;

        public Form1()
        {
            this.mgResponseQueue = new Queue();
            InitializeComponent();
            toast = new Toast();

            ThreadStart threadStart = new ThreadStart(loadDataResponse);
            Thread thread = new Thread(threadStart);

            thread.IsBackground = true;
            thread.Start();

            cbbSNMPVersion.Text = "2";
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (txtOIDValue.Text.Trim().Length <= 0)
            {
                toast.ShowAlert("Xin hãy nhập OID:");
            } else
            {
                Pdu pdu = new Pdu();
                Dictionary<Oid, AsnType> dicOID = null;
                SimpleSnmp snmp = null;

                loadSNMPParameters(out snmp);
                SnmpVersion version = SnmpVersion.Ver2;
                if (cbbSNMPVersion.SelectedItem.Equals("1"))
                {
                    version = SnmpVersion.Ver1;
                }
                
                VbCollection vbList = new VbCollection();
                vbList.Add(txtOIDValue.Text);

                pdu.SetVbList(vbList);

                // GET 
                pdu.Type = PduType.Get;
                dicOID = snmp.Get(version, pdu);

                if (dicOID != null && dicOID.Count > 0)
                {
                    this.mgResponseQueue.Enqueue(dicOID);
                }
            }
        }

        private void loadSNMPParameters(out SimpleSnmp snmp)
        {
            int timeOut = 10;
            // TODO: timeout by better way 
            int retry = 3;
            string IpAddress = txtIPAddress.Text;
            int port = Convert.ToInt32(txtPort.Text);
            string community = txtCommunityString.Text;
            snmp = new SimpleSnmp(IpAddress, port, community, timeOut, retry);
        }

        private void loadDataResponse()
        {
            this.miThreadState = 1;
            while (this.miThreadState != 0)
            {
                try
                {
                    Dictionary<Oid, AsnType> dicOID = (Dictionary<Oid, AsnType>)this.mgResponseQueue.Dequeue();
                    if (dicOID != null)
                    {
                        foreach (Oid oid in dicOID.Keys)
                        {
                            AsnType asnType = dicOID[oid];

                            appendRowSNMP(dgvSNMPListValue, new object[]
                            {
                                this.dgvSNMPListValue.Rows.Count + 1,
                                oid.ToString(),
                                asnType.ToString(),
                            });
                        }
                    }
                } 
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
                Thread.Sleep(200);
            }
        }

        private void appendRowSNMP(DataGridView dgv, object[] o)
        {
            if (dgv.InvokeRequired)
            {
                dgv.Invoke(new Action<DataGridView, object[]>(appendRowSNMP), new object[] { dgv, o });
            }
            else
            {
                dgv.Rows.Add(o);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.miThreadState = 0;
        }
    }
}
