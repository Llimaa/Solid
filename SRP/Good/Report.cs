namespace solid.srp.good;

public class Report 
{
    private readonly EmailService _emailService;

    public Report(EmailService emailService)
    {
        _emailService = emailService;
    }

    public void Generate() 
    {
        System.Console.WriteLine("Gerar relatorio");
        _emailService.Send("data");
    }
}
