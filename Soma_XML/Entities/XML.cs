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
        public static DateTime Emissao { get; set; }
        public static string Nota { get; set; }
        public static string Serie { get; set; }
        public static double Total { get; set; }


        public static void Ler_Arquivos(DataGridView gridXMLS, MaterialLabel total)
        {
            try
            {
                double valor = 0;
                string[] files;
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        files = Directory.GetFiles(fbd.SelectedPath);
                        foreach (var item in files)
                        {
                            string paths = Path.GetFileName(item);

                            if (paths.Contains("-PROCNFE.xml") || paths.Contains("-procnfe.xml") || paths.Contains("-procNFe.xml"))
                            {
                                XmlDocument xml = new XmlDocument();
                                xml.Load(item);
                                XmlNodeList vNF = xml.GetElementsByTagName("vNF");
                                XmlNodeList Emissao = xml.GetElementsByTagName("dhEmi");
                                XmlNodeList Nota = xml.GetElementsByTagName("nNF");
                                XmlNodeList Serie = xml.GetElementsByTagName("serie");
                                XmlNodeList Finalidade = xml.GetElementsByTagName("finNFe");
                                XmlNodeList tpNF = xml.GetElementsByTagName("tpNF");

                                DataGridViewRow row = (DataGridViewRow)gridXMLS.Rows[0].Clone();
                                row.Cells[0].Value = Emissao[0].InnerText;
                                row.Cells[1].Value = Nota[0].InnerText;
                                row.Cells[2].Value = Serie[0].InnerText;
                                row.Cells[3].Value = vNF[0].InnerText;
                                gridXMLS.Rows.Add(row);


                                double vr = double.Parse(vNF[0].InnerText, System.Globalization.CultureInfo.InvariantCulture);
                                if (Finalidade[0].InnerText == "4" && tpNF[0].InnerText == "1")
                                {
                                    valor -= vr;
                                }
                                else
                                {
                                    valor += vr;
                                }


                            }
                            total.Text = valor.ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
