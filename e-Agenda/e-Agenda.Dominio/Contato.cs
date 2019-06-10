using System;

public class Contato
{
    public int id { get; set; }

    public string Nome { get; set; }

    public string Telefone { get; set; }

    public string Cargo { get; set; }

    public string Email { get; set; }

    public string Departamento { get; set; }
    
    public Contato()
	{
	}
    public void Validacao()
    {
        if (String.IsNullOrEmpty(Nome))
        {
            throw new Exception("O nome não deve ser vazio!");
        }
         else if (Nome.Length < 10)
        {
            throw new Exception("O nome deve ter mais de 10 carcteres!");
        }
        else if (Telefone.Length < 8)
        {
            throw new Exception("O telefone deve ter mais de 8 digitos");
        }
        else if (Email == null)
        {
            throw new Exception("O email não pode ser nulo!");
        }
    }
}
