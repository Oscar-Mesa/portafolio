using System;
using Negocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Factura : Form
    {
        cls_producto obj_producto = new cls_producto();

        public Factura()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj_producto = new cls_producto(txt_codigo.Text, txt_nombre_producto.Text, txt_precio.Text,
                                           Convert.ToInt32(txt_cantidad.Text), Convert.ToString(cbx_categorias.SelectedIndex), 
                                            txt_fecha.Text,txt_especificaciones.Text);
            MessageBox.Show("Producto Registrado con éxtio");
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBS_ComercioElectronicoDataSet1.tbl_Categorias' Puede moverla o quitarla según sea necesario.
            this.tbl_CategoriasTableAdapter1.Fill(this.dBS_ComercioElectronicoDataSet1.tbl_Categorias);
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_consultar_producto_Click(object sender, EventArgs e)
        {
            obj_producto = new cls_producto();
            obj_producto.fnt_Consultar_Producto(txt_codigo.Text);
            txt_nombre_producto.Text = obj_producto.getNombre();
            txt_precio.Text = obj_producto.getPrecio();
            txt_cantidad.Text = Convert.ToString(obj_producto.getStock());
            cbx_categorias.SelectedIndex = Convert.ToInt32( obj_producto.getCategoria());
            txt_fecha.Text = obj_producto.getFecha();
            txt_especificaciones.Text = obj_producto.getEspecificaciones();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;
            dtg_producto.Rows.Add(txt_codigo.Text, txt_cantidaddtg.Text , txt_precio.Text);
            for (int i = 0; i < dtg_producto.Rows.Count; i++)
            {
                suma += Convert.ToInt32(dtg_producto.Rows[i].Cells[1].Value) *
                   Convert.ToInt32(dtg_producto.Rows[i].Cells[2].Value);
            }
            lbl_Subtotal.Text = Convert.ToString(suma);        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_consultar_cliente_Click(object sender, EventArgs e)
        {

        }
    }
}
