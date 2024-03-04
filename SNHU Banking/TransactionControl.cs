namespace SNHU_Banking;

public record Transaction(DateTime Date, string Description, decimal Amount, decimal NewBalance);

public partial class TransactionControl : UserControl
{
    public TransactionControl(Transaction transaction)
    {
        InitializeComponent();

        // Initalize controls with transaction data
        (dateLabel.Text, descriptionLabel.Text, amountLabel.Text, transactionBalanceLabel.Text) =
        (transaction.Date.ToString("MM/dd/yyyy"), transaction.Description.ToString(), ThemePalette.FormatMoney(transaction.Amount), ThemePalette.FormatMoney(transaction.NewBalance));

        (amountLabel.Text, amountLabel.ForeColor) =
            transaction.Amount > 0 ? ("+" + amountLabel.Text, Color.FromArgb(40, 150, 40))
                                   : (      amountLabel.Text, Color.FromArgb(200, 40, 40)); 
    }
}