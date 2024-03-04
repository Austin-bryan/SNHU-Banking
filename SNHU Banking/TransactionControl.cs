namespace SNHU_Banking;

// Purpose: Shows the transactions in real time as the suer makes them. 
// It depends on a transaction record that holds the data for this class
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

// The POD record for the transction Control;
public record Transaction(DateTime Date, string Description, decimal Amount, decimal NewBalance);