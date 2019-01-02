# SisNotas
Sistema de notas escolares
Nunca olvidar esto:
foreach (Control cont in gbDatosAlumno.Controls)
                {
                    if (cont is TextBox )
                    cont.Text = null;
                }
