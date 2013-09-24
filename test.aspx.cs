using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Salva_Click(object sender, EventArgs e)
    {

        UsersTableAdapters.Table_1TableAdapter dao = new UsersTableAdapters.Table_1TableAdapter();
        Users.Table_1DataTable dataTable = dao.GetData();
        Users.Table_1Row user = dataTable.NewTable_1Row();
        
        

        user.id = int.Parse(IdUser.Text);
        user.nome = Descrizione.Text;
        dataTable.AddTable_1Row(user);
        user.AcceptChanges();
        dataTable.AcceptChanges();
        dao.Update(dataTable);

    }
}
