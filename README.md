<h1 align="center">Proyecto Doctores en WPF</h1>

# Índice
1. [Introducción](##Introducción)
2. [Funcionalidades](##Funcionalidades)
3. [Aspectos a mejorar](##Aspectos a mejorar)
4. [Contacto](##Contacto)

##Introducción

Este proyecto simula un sistema básico de turnos para doctores y pacientes.
Está hecho en WPF utilizando C#. Usé SQL Server para la BDD.
El código de la app está en la carpeta de Perugini-WPF-Doctores.
Todos las sentencias tipo create (de todos los stored procedures, tablas y vistas de la base de datos) están en la carpeta "Base de datos"

A modo resúmen esta es una imágen de las tablas usadas para la BDD.
<img src="/Base de datos/BaseDeDatos.png" alt="Tablas de la BDD"/>


##Funcionalidades

Trabjé con la siguiente consigna.

. Todos los usuarios deben poder:
	-Crear un usuario y acceder con esas credenciales.
	-Entrar con sus credenciales.
	-Editar su perfil.
	-Ver sus turnos (con el estado de estos) y poder eliminarlos.
	-Ver sus recetas y poder eliminarlas.

. Los doctores deben poder:
	-Aceptar o rechazar turnos.
	-Crear recetas.
	-Cargar medicaciones.
	-Ver las medicaciones, actualizarlas y borrarlas.

. El paciente debe poder:
	-Pedir un turno.
	-No editar sus turnos.

. Generales:
	-Que se pueda entrar con unas credenciales y después poder entrar con otras.
	-Los turnos tienen tipos y estados.

. Respecto a verificador, debe ser una clase estática que se encargue de:
	-Verificar la cantidad mínima y máxima de caracteres de todos los datos ingresados.
	-Verificar que las boxes no estén vacías al ingresar datos.
	-Si el dato ingresado debe ser un int o float debe verificar que lo es.
	-Verificar caracteres dentro del documento:
		.Las cédulas deben tener 10 números.
		.Los DNI deben tener 8 números.
		.Los Pasaporte deben tener 3 letras y 6 números en ese orden.


##Aspectos a mejorar

Estos serían algunos errores y aspectos de mejora que fuí encontrando.

. Una cuenta de paciente se puede crear sin más, pero una de doc debería requerir una clave hardcodeada extra para evitar que una persona externa cree una cuenta de doctor. (Crear una inputbox en wpf superó mi límite de paciencia para algo que no es un requerimiento)
. Que el pueda doc agendar turnos? Debría aceptarlos el paciente? Un quilombo todas las implicancias.
. Que no se puedan aceptar turnos que se superpongan.
. Especialidades para los docs y para los turnos.
. Verificar que no se pueda tener dos usuarios con mismo usuario y clave o incluso datos únicos como documento.
. El tipo de documento se podría haber manejado mejor ya que está súper hardcodeado.

. Que se verifiquen la cantidad de caracteres.

##Contacto ✉️

* **[¡Envíame un email!](mailto:lorenaperuginikrause@gmail.com)**

<p align="left">
<a href="https://linkedin.com/in/lorenaperugini" target="blank"><img align="center" src="https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/linkedin.svg" alt="lorenaperugini" height="30" width="40" /></a>
</p>