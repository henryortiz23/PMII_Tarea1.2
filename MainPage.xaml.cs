using System.Text.RegularExpressions;
using Tarea_1._2.Models;
using Tarea_1._2.Views;

namespace Tarea_1._2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void onAddClicked(object sender, EventArgs e)
	{
        
        if (validarDatos())
		{
            EnviarInformacion();
        }
        else
        {
            ShowAlert();
        }
	}

    private bool validarDatos()
    {
        string txtNames = eNames.Text;
        string txtApellidos= eLastNames.Text;
		string txtEmail = eEmail.Text;
        bool result = false;

        if (txtNames==null || "".Equals(txtNames))
        { 
			eNames.Focus();
        }
        else if (txtApellidos == null || "".Equals(txtApellidos))
        {
            eLastNames.Focus();
        }
        else if (txtEmail == null)
        {
            eEmail.Focus();
        }
		else
		{
            string formatEmail = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            eEmail.Focus();
            result= Regex.IsMatch(txtEmail, formatEmail);
        }

        return result;
    }

   
	private async void ShowAlert()
	{
        await DisplayAlert("Informacion incorrecta", "Falta informacion o la informacion proporcionada es incorrecta.", "Aceptar");
    }


    private async void EnviarInformacion()
    {
        Empleado emple = new Empleado(
            eNames.Text,
            eLastNames.Text,
            eBd.Date,
            eEmail.Text
            );
        var PageResult = new ResultPage();
        PageResult.BindingContext = emple;

        await Navigation.PushAsync(PageResult);
    }
}

