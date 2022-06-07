using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using MaterialSkin.Controls;


namespace Soma_XML.Entities
{
    public static class XML
    {

        public static void Ler_Arquivos(DataGridView gridXMLS, Label total)
        {
            try
            {
                gridXMLS.Rows.Clear();
                gridXMLS.DataSource = null;
                double valor = 0;
                string[] files;
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        XmlDocument xml = new XmlDocument();
                        files = Directory.GetFiles(fbd.SelectedPath);
                        foreach (var item in files)
                        {
                            string paths = Path.GetFileName(item).ToUpper();
                            if (paths.Contains("-PROCNFE.XML"))
                            {
                                
                                xml.Load(item);
                                XmlNodeList vNF = xml.GetElementsByTagName("vNF");
                                XmlNodeList Emissao = xml.GetElementsByTagName("dhEmi");
                                XmlNodeList Nota = xml.GetElementsByTagName("nNF");
                                XmlNodeList Serie = xml.GetElementsByTagName("serie");
                                XmlNodeList Finalidade = xml.GetElementsByTagName("finNFe");
                                XmlNodeList tpNF = xml.GetElementsByTagName("tpNF");
                                XmlNodeList mod = xml.GetElementsByTagName("mod");

                                DataGridViewRow row = (DataGridViewRow)gridXMLS.Rows[0].Clone();
                                row.Cells[0].Value = Emissao[0].InnerText;
                                row.Cells[1].Value = Nota[0].InnerText;
                                row.Cells[2].Value = Serie[0].InnerText;


                                double vr = double.Parse(vNF[0].InnerText, System.Globalization.CultureInfo.InvariantCulture);
                                if (Finalidade[0].InnerText == "4" && tpNF[0].InnerText == "1")
                                {
                                    row.Cells[3].Value = "-"+vNF[0].InnerText;
                                    valor -= vr;
                                }
                                else
                                {
                                    row.Cells[3].Value = vNF[0].InnerText;
                                    valor += vr;
                                }
                                gridXMLS.Rows.Add(row);

                            }
                            if (paths.Contains("-PROCINUTNFE.XML"))
                            {

                                xml.Load(item);
                                XmlNodeList dhRecbto = xml.GetElementsByTagName("dhRecbto");
                                XmlNodeList nNFIni = xml.GetElementsByTagName("nNFIni");
                                XmlNodeList nNFFin = xml.GetElementsByTagName("nNFFin");
                                XmlNodeList mod = xml.GetElementsByTagName("mod");
                                XmlNodeList Serie = xml.GetElementsByTagName("serie");


                                if (nNFIni[0].InnerText == nNFFin[0].InnerText)
                                {
                                    DataGridViewRow row = (DataGridViewRow)gridXMLS.Rows[0].Clone();
                                    row.Cells[0].Value = dhRecbto[0].InnerText;
                                    row.Cells[1].Value = nNFIni[0].InnerText;
                                    row.Cells[2].Value = Serie[0].InnerText;
                                    row.Cells[3].Value = "INUTILIZADA";
                                    gridXMLS.Rows.Add(row);
                                }
                                if (nNFIni[0].InnerText != nNFFin[0].InnerText)
                                {
                                    for (int i = int.Parse(nNFIni[0].InnerText); i <= int.Parse(nNFFin[0].InnerText);  i++ )
                                    {
                                        DataGridViewRow row = (DataGridViewRow)gridXMLS.Rows[0].Clone();
                                        row.Cells[0].Value = dhRecbto[0].InnerText;
                                        row.Cells[1].Value = i;
                                        row.Cells[2].Value = Serie[0].InnerText;
                                        row.Cells[3].Value = "INUTILIZADA";
                                        gridXMLS.Rows.Add(row);
                                    }
                                }

                            }

                            if (paths.Contains("-PROCEVENTONFE.XML"))
                            {

                                xml.Load(item);
                                XmlNodeList Evento = xml.GetElementsByTagName("descEvento");
                                XmlNodeList tempChave = xml.GetElementsByTagName("chNFe");
                                string Nota = int.Parse(tempChave[0].InnerText.Substring(37, 6)).ToString();
                                if (Evento[0].InnerText.ToUpper() == "CANCELAMENTO")
                                {
                                    foreach (var items in files)
                                    {
                                        string path = Path.GetFileName(items).ToUpper();
                                        if (path.Contains(tempChave[0].InnerText))
                                        {
                                            
                                            xml.Load(items);
                                            XmlNodeList vNF = xml.GetElementsByTagName("vNF");
                                            XmlNodeList Emissao = xml.GetElementsByTagName("dhEmi");
                                            XmlNodeList nNF = xml.GetElementsByTagName("nNF");
                                            XmlNodeList Serie = xml.GetElementsByTagName("serie");
                                            double vr = double.Parse(vNF[0].InnerText, System.Globalization.CultureInfo.InvariantCulture);

                                            DataGridViewRow row = (DataGridViewRow)gridXMLS.Rows[0].Clone();
                                            row.Cells[0].Value = Emissao[0].InnerText;
                                            row.Cells[1].Value = nNF[0].InnerText;
                                            row.Cells[2].Value = Serie[0].InnerText;
                                            row.Cells[3].Value = "-" + vNF[0].InnerText;
                                            gridXMLS.Rows.Add(row);
                                            
                                            valor -= vr;
                                            break;
                                        }
                                    }
                                }
                            }


                        }


                        gridXMLS.Columns[0].Width = 15;
                        gridXMLS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        gridXMLS.AutoResizeColumns();
                        total.Text = valor.ToString("0,0.00");
                    }
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
               
            }
        }
    }
}
