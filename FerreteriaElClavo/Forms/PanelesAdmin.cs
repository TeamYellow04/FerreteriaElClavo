using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaElClavo.Forms
{
    internal class PanelesAdmin  
    {
        //Estos paneles son los que van en la pantalla del administrador
        public Panel panelUsuario { get; private set; }
        public Panel panelProveedor { get; private set; }
        public Panel panelInventario { get; private set; }
        public Panel panelVistaProductos { get; private set; }
        //Estos paneles son los que van en la pantalla del administrador 
        public PanelesAdmin()
        {
            //direcciones de elementos que iran dentro de los paneles
            int labelWidth = 100;
            int textBoxWidth = 200;
            int controlHeight = 20;
            int startX = 10;
            int startY = 10;
            int verticalSpacing = 40;

            //direcciones para los botones
            int buttonWidth = 100;
            int buttonHeight = 30;
            int buttonSpacing = 10;
            int buttonsStartX = 10;
            int buttonsStartY = 280;

            //Panel Usuario
            #region "Panel Usuario"

            panelUsuario =  PanelesBases();
            panelUsuario.Location = new Point(185, 56);
            panelUsuario.Size = new Size(449, 353);
            panelUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panelUsuario.Visible = false;

            Label TituloUsuario = new Label();
            TituloUsuario.Text = "Agregar/Eliminar Usuario Vendedor";
            TituloUsuario.Font = new Font(TituloUsuario.Font.FontFamily, 14, FontStyle.Bold);
            TituloUsuario.TextAlign = ContentAlignment.MiddleCenter;
            TituloUsuario.Dock = DockStyle.Top;
            panelUsuario.Controls.Add(TituloUsuario);

            Label NombreUsuario = new Label();
            NombreUsuario.Text = "Nombre";
            NombreUsuario.Location = new Point(startX, startY + verticalSpacing);
            NombreUsuario.Size = new Size(labelWidth, controlHeight);
            panelUsuario.Controls.Add(NombreUsuario);

            TextBox txtNombreUsuario = new TextBox();
            txtNombreUsuario.Location = new Point(startX + labelWidth + 5, startY + verticalSpacing - 2);
            txtNombreUsuario.Size = new Size(textBoxWidth, controlHeight);
            txtNombreUsuario.AutoSize = true;
            panelUsuario.Controls.Add(txtNombreUsuario);

            Label ApellidoUsuario = new Label();
            ApellidoUsuario.Text = "Apellido";
            ApellidoUsuario.Location = new Point(startX, startY + 2 * verticalSpacing);
            ApellidoUsuario.Size = new Size(labelWidth, controlHeight);
            ApellidoUsuario.AutoSize = true;
            panelUsuario.Controls.Add(ApellidoUsuario);

            TextBox txtApellidoUsuario = new TextBox();
            txtApellidoUsuario.Location = new Point(startX + labelWidth + 5, startY + 2 * verticalSpacing - 2);
            txtApellidoUsuario.Size = new Size(textBoxWidth, controlHeight);
            panelUsuario.Controls.Add(txtApellidoUsuario);

            Label RolUsuario = new Label();
            RolUsuario.Text = "Rol";
            RolUsuario.Location = new Point(startX, startY + 3 * verticalSpacing);
            RolUsuario.Size = new Size(labelWidth, controlHeight);
            RolUsuario.AutoSize = true;
            panelUsuario.Controls.Add(RolUsuario);

            TextBox txtRolUsuario = new TextBox();
            txtRolUsuario.Location = new Point(startX + labelWidth + 5, startY + 3 * verticalSpacing - 2);
            txtRolUsuario.Size = new Size(textBoxWidth, controlHeight);
            panelUsuario.Controls.Add(txtRolUsuario);

            Label User = new Label();
            User.Text = "Usuario";
            User.Location = new Point(startX, startY + 4 * verticalSpacing);
            User.Size = new Size(labelWidth, controlHeight);
            User.AutoSize = true;
            panelUsuario.Controls.Add(User);



            TextBox txtUsersalida = new TextBox();
            txtUsersalida.Location = new Point(startX + labelWidth + 5, startY + 4 * verticalSpacing - 2);
            txtUsersalida.Size = new Size(textBoxWidth, controlHeight);
            txtUsersalida.ReadOnly = true;
            panelUsuario.Controls.Add(txtUsersalida);

            Label ContraUsuario = new Label();
            ContraUsuario.Text = "Contraseña";
            ContraUsuario.Location = new Point(startX, startY + 5 * verticalSpacing);
            ContraUsuario.Size = new Size(labelWidth, controlHeight);
            ContraUsuario.AutoSize = true;
            panelUsuario.Controls.Add(ContraUsuario);

            TextBox txtContraUsuario = new TextBox();
            txtContraUsuario.Location = new Point(startX + labelWidth + 5, startY + 5 * verticalSpacing - 2);
            txtContraUsuario.Size = new Size(textBoxWidth, controlHeight);
            txtContraUsuario.ReadOnly = true;
            panelUsuario.Controls.Add(txtContraUsuario);


            //Botones del panel Usuario

            Button botonGuardarUsuario = new Button();
            botonGuardarUsuario.Text = "Guardar";
            botonGuardarUsuario.Size = new Size(buttonWidth, buttonHeight);
            botonGuardarUsuario.Location = new Point(buttonsStartX, buttonsStartY);
            panelUsuario.Controls.Add(botonGuardarUsuario);
            botonGuardarUsuario.Click += BotonGuardarUsuario_Click;

            Button botonEliminarUsuario = new Button();
            botonEliminarUsuario.Text = "ELiminar";
            botonEliminarUsuario.Size = new Size(buttonWidth, buttonHeight);
            botonEliminarUsuario.Location = new Point(buttonsStartX + 2 * (buttonWidth + buttonSpacing), buttonsStartY);
            panelUsuario.Controls.Add(botonEliminarUsuario);
            botonEliminarUsuario.Click += BotonEliminarUsuario_Click;
            #endregion

            //Panel Proveedor
            #region "Panel Proveedor"
            panelProveedor = new Panel();
            panelProveedor.Location = new Point(185, 56);
            panelProveedor.Size = new Size(449, 353);
            panelProveedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panelProveedor.Visible = true;

            Label TituloProveedores = new Label();
            TituloProveedores.Text = "Proveedores";
            TituloProveedores.Font = new Font(TituloProveedores.Font.FontFamily,14, FontStyle.Bold);
            TituloProveedores.TextAlign  = ContentAlignment.MiddleCenter;
            TituloProveedores.Dock = DockStyle.Top;
            panelProveedor.Controls.Add(TituloProveedores);

            //Tabla con datos del proveedor

            DataGridView TablaProveedores = new DataGridView();
            TablaProveedores.Size = new Size(398, 288);
            TablaProveedores.Location = new Point(17, 54);
           
            DataGridViewTextBoxColumn ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnaNombre.HeaderText = " Nombre ";
            ColumnaNombre.DataPropertyName = "Nombre";
            TablaProveedores.Columns.Add(ColumnaNombre);

            DataGridViewTextBoxColumn ColumnaEmail = new DataGridViewTextBoxColumn();
            ColumnaEmail.HeaderText = " Email ";
            ColumnaEmail.DataPropertyName = "Email";
            TablaProveedores.Columns.Add(ColumnaEmail);

            DataGridViewTextBoxColumn ColumnaDireccion = new DataGridViewTextBoxColumn();
            ColumnaDireccion.HeaderText = " Direccion ";
            ColumnaDireccion.DataPropertyName = "Direccion";
            TablaProveedores.Columns.Add(ColumnaDireccion);

            DataGridViewTextBoxColumn ColumnaTelefono = new DataGridViewTextBoxColumn();
            ColumnaTelefono.HeaderText = " Telefono ";
            ColumnaTelefono.DataPropertyName = "Telefono";
            TablaProveedores.Columns.Add(ColumnaTelefono);

            

            panelProveedor.Controls.Add(TablaProveedores);
            #endregion

            //panelVistaProducto
            #region "Panel Vista Producto"
            panelVistaProductos = new Panel();
            panelVistaProductos.Location = new Point(185, 56);
            panelVistaProductos.Size = new Size(449, 353);
            panelVistaProductos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panelVistaProductos.Visible = true;

            DataGridView TablaVistaProductos = new DataGridView();
            TablaVistaProductos.Size = new Size(360, 288);
            TablaVistaProductos.Location = new Point(17, 40);
            panelVistaProductos.Controls.Add(TablaVistaProductos);

            DataGridViewTextBoxColumn NombreProducto = new DataGridViewTextBoxColumn();
            NombreProducto.HeaderText = " Nombre ";
            NombreProducto.DataPropertyName = "Nombre";
            TablaVistaProductos.Columns.Add(NombreProducto);

            DataGridViewTextBoxColumn CantidadProducto = new DataGridViewTextBoxColumn();
            CantidadProducto.HeaderText = " Cantidad ";
            CantidadProducto.DataPropertyName = "Cantidad";
            TablaVistaProductos.Columns.Add(CantidadProducto);

            DataGridViewTextBoxColumn DescripcionProducto = new DataGridViewTextBoxColumn();
            DescripcionProducto.HeaderText = "Descripcion";
            DescripcionProducto.DataPropertyName = "Descripcion";
            TablaVistaProductos.Columns.Add(DescripcionProducto);

            DataGridViewTextBoxColumn PrecioProducto = new DataGridViewTextBoxColumn();
            PrecioProducto.HeaderText = "Precio";
            PrecioProducto.DataPropertyName = "Precio";
            TablaVistaProductos.Columns.Add(PrecioProducto);

            DataGridViewTextBoxColumn UN_MedidaProducto = new DataGridViewTextBoxColumn();
            UN_MedidaProducto.HeaderText = "UN_Medida";
            UN_MedidaProducto.DataPropertyName = "UN_Medida";
            TablaVistaProductos.Columns.Add(UN_MedidaProducto);

            DataGridViewTextBoxColumn CategoriaProducto = new DataGridViewTextBoxColumn();
            CategoriaProducto.HeaderText = "Categoria";
            CategoriaProducto.DataPropertyName = "Categoria";
            TablaVistaProductos.Columns.Add(CategoriaProducto);

            DataGridViewTextBoxColumn ProveedorProducto = new DataGridViewTextBoxColumn();
            ProveedorProducto.HeaderText = "Proveedor";
            ProveedorProducto.DataPropertyName = "Proveedor";
            TablaVistaProductos.Columns.Add(ProveedorProducto);

            TextBox Buscar = new TextBox();
            Buscar.Location = new Point(17,12);
            Buscar.Size = new Size(205, 20);
            panelVistaProductos.Controls.Add(Buscar);

            //Botones vista productos

            Button botonAgregar = new Button();
            botonAgregar.Text = "Agregar"; 
            botonAgregar.Location = new Point(379, 106);
            botonAgregar.Size = new Size(60, 41);
            panelVistaProductos.Controls.Add(botonAgregar);
            botonAgregar.Click += BotonAgregarProductos_Click;

            Button botonBorrar = new Button();
            botonBorrar.Text = "Eliminar";
            botonBorrar.Location = new Point(379, 165);
            botonBorrar.Size = new Size(60, 41);
            panelVistaProductos.Controls.Add(botonBorrar);
            botonBorrar.Click += BotonBorrarProductos_Click;

            Button botonEditar = new Button();
            botonEditar.Text = "Editar";
            botonEditar.Location = new Point(379, 229);
            botonEditar.Size = new Size(60, 41);
            panelVistaProductos.Controls.Add(botonEditar);
            botonEditar.Click += BotonEditarProductos_Click;

            Button botonBuscar = new Button();
            botonBuscar.Text = "Buscar";
            botonBuscar.Location = new Point(263, 12);
            botonBuscar.Size = new Size(75, 23);
            panelVistaProductos.Controls.Add(botonBuscar);
            botonBuscar.Click += BotonBuscarProductos_Click;
            #endregion

            //Panel Inventario
            #region "Panel Inventario"
            panelInventario = new Panel();
            panelInventario.Location = new Point(185, 56);
            panelInventario.Size = new Size(449, 353);
            panelInventario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panelInventario.Visible = true;
           

            //Elementos del panel Inventario

            Label NombreInventario = new Label();
            NombreInventario.Text = "Nombre";
            NombreInventario.Location = new Point(startX, startY);
            NombreInventario.Size = new Size(labelWidth, controlHeight);
            panelInventario.Controls.Add(NombreInventario);

            TextBox txtNombreInventario = new TextBox();
            txtNombreInventario.Location= new Point(startX + labelWidth + 5, startY - 2);
            txtNombreInventario.Size= new Size(textBoxWidth, controlHeight);
            txtNombreInventario.AutoSize = true;
            panelInventario.Controls.Add(txtNombreInventario);

            Label CantidadInventario = new Label();
            CantidadInventario.Text = "Cantidad";
            CantidadInventario.Location = new Point(startX, startY + verticalSpacing);
            CantidadInventario.Size = new Size(labelWidth, controlHeight);
            CantidadInventario.AutoSize = true;
            panelInventario.Controls.Add(CantidadInventario);

            TextBox txtCantidadInventario = new TextBox();
            txtCantidadInventario.Location = new Point(startX + labelWidth + 5, startY + verticalSpacing - 2);
            txtCantidadInventario.Size = new Size(textBoxWidth, controlHeight);
            panelInventario.Controls.Add(txtCantidadInventario);

            Label DescripcionInventario = new Label();
            DescripcionInventario.Text = "Descripcion";
            DescripcionInventario.Location = new Point(startX, startY + 2 * verticalSpacing);
            DescripcionInventario.Size = new Size(labelWidth, controlHeight);
            DescripcionInventario.AutoSize = true;
            panelInventario.Controls.Add(DescripcionInventario);

            TextBox txtDescripcionInventario = new TextBox();
            txtDescripcionInventario.Location = new Point(startX + labelWidth + 5, startY + 2 * verticalSpacing - 2);
            txtDescripcionInventario.Size = new Size(textBoxWidth, controlHeight);
            panelInventario.Controls.Add(txtDescripcionInventario);

            Label PrecioInventario = new Label();
            PrecioInventario.Text = "Precio";
            PrecioInventario.Location = new Point(startX, startY + 3 * verticalSpacing);
            PrecioInventario.Size = new Size(labelWidth, controlHeight);
            PrecioInventario.AutoSize = true;
            panelInventario.Controls.Add(PrecioInventario);

            TextBox txtPrecioInventario= new TextBox();
            txtPrecioInventario.Location = new Point(startX + labelWidth + 5, startY + 3 * verticalSpacing - 2);
            txtPrecioInventario.Size = new Size(textBoxWidth, controlHeight);
            panelInventario.Controls.Add(txtPrecioInventario);

            Label UNMedidaInventario = new Label();
            UNMedidaInventario.Text = "UN_Medida";
            UNMedidaInventario.Location = new Point(startX, startY + 4 * verticalSpacing);
            UNMedidaInventario.Size = new Size(labelWidth, controlHeight);
            UNMedidaInventario.AutoSize = true;
            panelInventario.Controls.Add(UNMedidaInventario);

            TextBox txtUNMedidaInventario = new TextBox();
            txtUNMedidaInventario.Location = new Point(startX + labelWidth + 5, startY + 4 * verticalSpacing - 2);
            txtUNMedidaInventario.Size = new Size(textBoxWidth, controlHeight);
            panelInventario.Controls.Add(txtUNMedidaInventario);

            Label CategoriaInventario = new Label();
            CategoriaInventario.Text = "Categoria";
            CategoriaInventario.Location = new Point(startX, startY + 5 * verticalSpacing);
            CategoriaInventario.Size = new Size(labelWidth, controlHeight);
            CategoriaInventario.AutoSize = true;
            panelInventario.Controls.Add(CategoriaInventario);

            TextBox txtCategoriaInventario = new TextBox();
            txtCategoriaInventario.Location = new Point(startX + labelWidth + 5, startY + 5 * verticalSpacing - 2);
            txtCategoriaInventario.Size = new Size(textBoxWidth, controlHeight);
            panelInventario.Controls.Add(txtCategoriaInventario);

            Label ProveedorInventario = new Label();
            ProveedorInventario.Text = "Proveedor";
            ProveedorInventario.Location = new Point(startX, startY + 6 * verticalSpacing);
            ProveedorInventario.Size = new Size(labelWidth, controlHeight);
            ProveedorInventario.AutoSize = true;
            panelInventario.Controls.Add(ProveedorInventario);

            TextBox txtProveedorInventario = new TextBox();
            txtProveedorInventario.Location = new Point(startX + labelWidth + 5, startY + 6 * verticalSpacing - 2);
            txtProveedorInventario.Size = new Size(textBoxWidth, controlHeight);
            panelInventario.Controls.Add(txtProveedorInventario);

                             
        
           
            //Botones para CRUD inventario
            Button botonGuardar = new Button();
            botonGuardar.Text = "Guardar";
            botonGuardar.Size = new Size(buttonWidth, buttonHeight);
            botonGuardar.Location = new Point(buttonsStartX, buttonsStartY);
            panelInventario.Controls.Add(botonGuardar);
            botonGuardar.Click += BotonGuardarInventario_Click;
                                   
           

       

            #endregion

        }




        private Panel PanelesBases()
        {
            return new Panel();

        }
      
        //Botones vista producto
        private void BotonAgregarProductos_Click(object sender, EventArgs e)
        {


        }
        private void BotonEditarProductos_Click(object sender, EventArgs e)
        {


        }
        private void BotonBorrarProductos_Click(object sender, EventArgs e)
        {


        }
        private void BotonBuscarProductos_Click(object sender, EventArgs e)
        {


        }
        //Botones panel Usuario
        private void BotonGuardarUsuario_Click(object sender, EventArgs e)
        {


        }
        private void BotonEliminarUsuario_Click(object sender, EventArgs e)
        {


        }

        //Botones Inventario
        private void BotonGuardarInventario_Click(object sender, EventArgs e)
        {
           
           
        }
      

        //Boton
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            

        }
       
       
       




    }
}
