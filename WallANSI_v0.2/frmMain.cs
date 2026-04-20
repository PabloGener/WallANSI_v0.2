using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * colorear el texto en rtfTexto
 * 
 */


namespace WallANSI_v0._2
{
    public partial class frmMain : Form {

        int cclr;   //cambiar color en...: 1: rtfSecuencia 2: rtfTexto

        public frmMain() {
            InitializeComponent();
            rtfTexto.Font = new Font("Courier New", 12, FontStyle.Regular, GraphicsUnit.Point);
            rtfSecuencia.Font = new Font("Courier New", 12, FontStyle.Regular, GraphicsUnit.Point);


            if (File.Exists("boveda.rtf")) {
                rtfBoveda.LoadFile("boveda.rtf");
            }
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e) {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (archivos.Length == 0) return;

            string rutaArchivo = archivos[0];

            if (Path.GetExtension(rutaArchivo).ToLower() == ".txt") {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                if (lineas.Length == 0) return;

                foreach (string linea in lineas) {
                    hacerUnaTxtLine(linea);
                }
                rtfTexto.Select(0, rtfTexto.Text.Length);
                rtfTexto.SelectionFont = new Font("Courier New", 12);
                //MessageBox.Show($"Archivo cargado: {Path.GetFileName(rutaArchivo)}", "WallANSI");
            }
            else {
                MessageBox.Show("Solo se aceptan archivos .txt", "Error");
            }
        }

        private void frmMain_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void btnColores_Click(object sender, EventArgs e) {
            gbColores.Visible = gbColores.Visible ? false : true;

        }

        private void btnASCII_Click(object sender, EventArgs e) {
            txtASCII.Visible = txtASCII.Visible ? false : true;
        }

        private void txtASCII_MouseUp(object sender, MouseEventArgs e) {
            if (txtASCII.SelectionLength < 1) return;

            rtfSecuencia.Select(rtfSecuencia.Text.Length, 0);
            rtfSecuencia.SelectedText = txtASCII.SelectedText;
        }

        private void btnGuardarANSI_Click(object sender, EventArgs e) {
            guardarANSI();
        }

        private void rtfSecuencia_DoubleClick(object sender, EventArgs e) {
            gbBoveda.Visible = true;
        }

        private void cmdCerrarBoveda_Click(object sender, EventArgs e) {
            gbBoveda.Visible = false;
        }

        private void cmdGuardarBoveda_Click(object sender, EventArgs e) {
            rtfBoveda.SaveFile("boveda.rtf");

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            rtfBoveda.SaveFile("boveda.rtf");

        }

        private void cmdPegar_Click(object sender, EventArgs e) {
            if (rtfBoveda.SelectedText.Length == 0) return;
            
            rtfSecuencia.Text = "";
            rtfSecuencia.SelectedRtf = rtfBoveda.SelectedRtf;

        }
        private void rtfSecuencia_MouseUp(object sender, MouseEventArgs e) {
            cclr = 1;

        }

        private void rtfTexto_MouseUp(object sender, MouseEventArgs e) {
            cclr = 2;
        }



        /*
        ##############################################################
        ##                                                          ##
        ##      M E T O D O S       P R O P I O S                   ##
        ##                                                          ##
        ##############################################################
        */


        private void hacerUnaCharline() {
            int s = 0;
            string cincuenta = new string(' ', 50);

            rtfTexto.AppendText(Environment.NewLine);
            
            quinceChars();
            rtfTexto.AppendText(cincuenta);
            quinceChars();
        }

        private void hacerUnaTxtLine(string strLinea) {
            hacerUnaCharline();
            int c = rtfTexto.Text.Length - 65;

            
            
            for (int i = 0; i < strLinea.Length - 1; i++) {
                rtfTexto.Select(c, 1);
                rtfTexto.SelectedText = strLinea[i].ToString();

                rtfTexto.Select(c, 1);
                rtfTexto.SelectionColor = Color.White;

                c++;
                if (c == rtfTexto.Text.Length - 15) {
                    hacerUnaCharline();
                    c = rtfTexto.Text.Length - 65;
                }
            }
        }

        private void quinceChars() {
            int s = 0;
            for (int i = 0; i < 15; i++) {
                rtfSecuencia.Select(s, 1);
                rtfTexto.Select(rtfTexto.Text.Length, 0);
                rtfTexto.SelectedRtf = rtfSecuencia.SelectedRtf;
                s++;
                if (s == rtfSecuencia.Text.Length) s = 0;
            }
        }

        private void guardarANSI() {
            FileInfo archivoANSI;
            archivoANSI = new FileInfo("test.ans");
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK) {
                try {
                    archivoANSI = new FileInfo(ofd.FileName);
                }
                    catch (SecurityException ex) {
                    
                    
                }
            }
            
            List<String> lineasANSI = new List<string>();
            
            Color sClr = Color.White;
            char cc;
            string cntANSI = "";

            for (int i = 0; i < rtfTexto.Text.Length - 1; i++) {

                if (rtfTexto.Text[i] == '\n') {
                    lineasANSI.Add(cntANSI);
                    cntANSI = "";
                    continue; 
                }

                rtfTexto.Select(i, 1);
                sClr = rtfTexto.SelectionColor;
                cc = rtfTexto.Text[i];
                if (cc > 175 && cc < 220) cc = cambiarASCII(cc);
                
                cntANSI += ColorToAnsiCode(sClr) + cc;

            }

            File.WriteAllLines(archivoANSI.FullName, lineasANSI, Encoding.GetEncoding(437));

        }




        private void cambiarColor(object sender, EventArgs e) {
            Button btnActual = (Button)sender;

            switch (cclr) {
                case 1:
                    if (rtfSecuencia.SelectionLength > 0) {
                        rtfSecuencia.SelectionColor = btnActual.BackColor;
                    }
                    break;
                case 2:
                    if (rtfTexto.SelectionLength > 0) {
                            rtfTexto.SelectionColor = btnActual.BackColor;
                        }
                    break;

            }
        }

        private string ColorToAnsiCode(Color color) {
            // Colores normales
            if (color == Color.Black) return "\u001b[30m";
            if (color == Color.DarkRed) return "\u001b[31m";
            if (color == Color.DarkGreen) return "\u001b[32m";
            if (color == Color.Goldenrod) return "\u001b[33m";
            if (color == Color.DarkBlue) return "\u001b[34m";
            if (color == Color.DarkMagenta) return "\u001b[35m";
            if (color == Color.DarkCyan) return "\u001b[36m";
            if (color == Color.Silver) return "\u001b[37m";

            // Colores brillantes
            if (color == Color.Blue) return "\u001b[34;1m";
            if (color == Color.Lime) return "\u001b[32;1m";
            if (color == Color.Cyan) return "\u001b[36;1m";
            if (color == Color.Red) return "\u001b[31;1m";
            if (color == Color.Magenta) return "\u001b[35;1m";
            if (color == Color.Yellow) return "\u001b[33;1m";
            if (color == Color.White) return "\u001b[37;1m";

            return "\u001b[0m";
        }

        private char cambiarASCII(int c) {

            switch (c) {
                case 176: return '░';
                case 177: return '▒';
                case 178: return '▓';
                case 179: return '│';
                case 180: return '┤';
                case 181: return '╡';
                case 182: return '╢';
                case 183: return '╖';
                case 184: return '╕';
                case 185: return '╣';
                case 186: return '║';
                case 187: return '╗';
                case 188: return '╝';
                case 189: return '╜';
                case 190: return '╛';
                case 191: return '┐';
                case 192: return '└';
                case 193: return '┴';
                case 194: return '┬';
                case 195: return '├';
                case 196: return '─';
                case 197: return '┼';
                case 198: return '╞';
                case 199: return '╟';
                case 200: return '╚';
                case 201: return '╔';
                case 202: return '╩';
                case 203: return '╦';
                case 204: return '╠';
                case 205: return '═';
                case 206: return '╬';
                case 207: return '╧';
                case 208: return '╨';
                case 209: return '╤';
                case 210: return '╥';
                case 211: return '╙';
                case 212: return '╘';
                case 213: return '╒';
                case 214: return '╓';
                case 215: return '╫';
                case 216: return '╪';
                case 219: return '█';
                default: return (char)c;
            }

        }

        
    }
}