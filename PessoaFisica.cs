public class PessoaFisica : Proprietario
{
    public string _idpessoafisica;
    private string _cpf;
    public string _rg;
    public string _datanascimento;
    public string _sexo;

    public void SetCpf(string cpf)
    {
        cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length == 11)
        {
            _cpf = cpf;
        }
        else
        {
            throw new Exception("O CPF deve conter 11 caracteres.");
        }
    }
}
