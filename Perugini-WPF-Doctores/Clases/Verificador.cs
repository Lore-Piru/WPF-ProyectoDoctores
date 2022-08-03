using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Perugini_WPF_Doctores.Clases
{
	public static class Verificador
	{
		public static bool verificarStringLargo(string dato)
		{
			if (dato == "")
			{
				MessageBox.Show("Uno o más campos no pueden estar vacíos, por favor completelos. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
				return false;
			}

			if (dato.Length > 50)
			{
				MessageBox.Show($"El campo \"{dato}\" debe ser de máximo 50 caracteres, por favor cambielo. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
				return false;
			}
			return true;
		}

		public static bool verificarStringsCortos(List<string> datos)
		{
			foreach (string dato in datos)
			{
				if (dato == "")
				{
					MessageBox.Show("Uno o más campos no pueden estar vacíos, por favor completelos. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}

				if (dato.Length > 20)
				{
					MessageBox.Show($"El campo \"{dato}\" debe ser de máximo 50 caracteres, por favor cambielo. Muchas gracias", "Error al guardar", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}
			}
			return true;
		}

		public static bool verificarCredenciales (string nombreUsuario, string clave)
		{
			if (nombreUsuario == "" || clave == "")
			{
				MessageBox.Show("Uno o más campos no pueden estar vacíos, por favor completelos. Muchas gracias", "Error en las credenciales", MessageBoxButton.OK, MessageBoxImage.Error);
				return false;
			}

			if (nombreUsuario.Length > 10)
			{
				MessageBox.Show("El nombre de usuario debe ser de máximo 10 caracteres, por favor cambielo. Muchas gracias", "Error en las credenciales", MessageBoxButton.OK, MessageBoxImage.Error);
				return false;
			}

			if (clave.Length > 10)
			{
				MessageBox.Show("La clave debe ser de máximo 10 caracteres, por favor cambielo. Muchas gracias", "Error en las credenciales", MessageBoxButton.OK, MessageBoxImage.Error);
				return false;
			}

			return true;
		}
		public struct VerificadorInt
		{
			public bool respuesta;
			public int num;
		}

		public static VerificadorInt verificarInt (string dato)
		{
			VerificadorInt v = new VerificadorInt();
			int num;
			bool respuesta = int.TryParse(dato, out num);
			v.respuesta = respuesta;
			v.num = num;
			return v;
		}

		public struct VerificadorFloat
		{
			public bool respuesta;
			public float num;
		}

		public static VerificadorFloat verificarFloat(string dato)
		{
			VerificadorFloat v = new VerificadorFloat();
			float num;
			bool respuesta = float.TryParse(dato.Replace(',', '.'), out num);
			v.respuesta = respuesta;
			v.num = num;
			return v;
		}

		public static bool verificarDocumentos(int tipoDoc, string numDeDoc_string)
		{
			switch (tipoDoc)
            {
				case 0:// Cédula - 10 números
					if (numDeDoc_string.Length == 10)
                    {
						if (verificarInt(numDeDoc_string).respuesta)
							return true;
						else
							MessageBox.Show("El número de cédula no debe contener letras o signos, por favor cambielo. Muchas gracias", "Error en el número de cédula", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
					else
						MessageBox.Show("El número de cédula debe ser de 10 dígitos, por favor cambielo. Muchas gracias", "Error en el número de cédula", MessageBoxButton.OK, MessageBoxImage.Error);
					break;

				case 1:// DNI - 8 números
					if (numDeDoc_string.Length == 8)
					{
						if (verificarInt(numDeDoc_string).respuesta)
							return true;
						else
							MessageBox.Show("El número de documento no debe contener letras o signos, por favor cambielo. Muchas gracias", "Error en el número de documento", MessageBoxButton.OK, MessageBoxImage.Error);
					}
					else
						MessageBox.Show("El número de documento debe ser de 8 dígitos, por favor cambielo. Muchas gracias", "Error en el número de documento", MessageBoxButton.OK, MessageBoxImage.Error);
					break;

				case 2:// Pasaporte - 3 letras y 6 números en ese orden
					if (numDeDoc_string.Length == 9)
                    {
						for(int i = 0; i < 3; i++)
                        {
							if(CharUnicodeInfo.GetUnicodeCategory(numDeDoc_string[i]) != UnicodeCategory.UppercaseLetter)
                            {
								MessageBox.Show("El número de pasaporte debe comenzar con 3 letras, por favor cambielo. Muchas gracias", "Error en el número de pasaporte", MessageBoxButton.OK, MessageBoxImage.Error);
								return false;
							}
                        }

						string numDePasaporte = numDeDoc_string.Substring(3);

						if(verificarInt(numDePasaporte).respuesta)
							return true;
						else
							MessageBox.Show("El número de pasaporte debe terminar con 6 números, por favor cambielo. Muchas gracias", "Error en el número de pasaporte", MessageBoxButton.OK, MessageBoxImage.Error);

					}
					else
						MessageBox.Show("El número de pasaporte debe ser de 9 dígitos (3 letras y 6 números), por favor cambielo. Muchas gracias", "Error en el número de pasaporte", MessageBoxButton.OK, MessageBoxImage.Error);
					break;
			}

			return false;
		}
	}
}
