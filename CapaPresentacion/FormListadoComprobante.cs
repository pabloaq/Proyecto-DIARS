﻿using CapaDatos;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormListadoComprobante : Form
    {
        public FormListadoComprobante()
        {
            InitializeComponent();
            listaComprobante();
        }

        private void listaComprobante()
        {
            dgvComprobante.DataSource = LogComprobante.Instancia.ListarComprobante();
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvComprobante.DataSource = LogComprobante.Instancia.buscarComprobante(txtNombreCliente.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}