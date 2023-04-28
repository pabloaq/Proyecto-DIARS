﻿using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace MantenedorProducto
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
            listaProductos();
        }

        private void listaProductos()
        {
            dgv_listaProductos.DataSource = LogProducto.Instancia.ListarProducto();
        }

        private void dgv_listaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            dt_fechaCaducidad.Enabled = true;
        }
    }
}
