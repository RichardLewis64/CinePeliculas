Public void Guardar_Button_Click(object sender, EventArgs e)
{
    login();
}
Public void Enviar_Button_Click(object sender, EventArgs e)
{
    login();
}

private void login()
{
    SqlConnection cn= newSqlConnection("Datasource=DESKTOP-3NPAITV\SQLEXPRESS;initial catalog=BDSyaTake;Integrate Security=true");
cn.open;
SqlComand cn= new SqlComand("select ID,Nombre,CI from CINE where Nombre='"+txtCliente1.Text.ToString+"'and CI='"+txtCI.text+"' ",cn);
SqlDataReader dr= cn.ExecuteReader();
if(dr.Read())
{
   MensajeBox.Show("Login Exitoso","Sistema");

   MDIParent1 fr= new MDIParent1();
   fr.ShowDialog();
}
else
MensajeBox.Show("Login Exitoso","Sistema");



}