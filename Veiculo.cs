using System.Reflection;

public class Veiculo
{
    public string _idveiculo;
    private string _niv;
    public string _placa;
    public string _motor;
    public string _renavam;
    public string _anomodelo;
    public string _situacao;
    public string _cor;
    public Cidade _cidade;
    public Proprietario _proprietario;
    public Modelo _modelo;

    public void SetNiv(string niv)
    {
        if (niv.Length == 17)
        {
            _niv = niv;
        }
        else
        {
            throw new Exception("O NIV deve conter 17 caracteres");
        }
    }

    public string GetNiv()
    {
        return _niv;
    }
}
