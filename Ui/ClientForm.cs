namespace CargoPlus;

internal sealed class ClientForm : Form
{
    private readonly TextBox _name = Theme.Box();
    private readonly TextBox _surname = Theme.Box();
    private readonly TextBox _phone = Theme.Box();
    private readonly TextBox _phone2 = Theme.Box();
    private readonly TextBox _notes = Theme.Box();
    private readonly Label _error = new() { ForeColor = Theme.Danger, AutoSize = false, Height = 36, Font = Theme.Ui };

    public ClientInfo? Client { get; private set; }

    public ClientForm(string name, string phone)
    {
        Text = UiText.AddClientTitle;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        StartPosition = FormStartPosition.CenterParent;
        MaximizeBox = false;
        MinimizeBox = false;
        ClientSize = new Size(460, 430);
        BackColor = Color.White;
        Font = Theme.Ui;
        _name.Text = name;
        _phone.Text = phone;
        _name.MaxLength = 80;
        _surname.MaxLength = 80;
        _phone.MaxLength = 40;
        _phone2.MaxLength = 40;
        _notes.MaxLength = 500;
        _notes.Multiline = true;
        _notes.Height = 72;
        _phone.Font = Theme.Digits;
        _phone2.Font = Theme.Digits;

        var grid = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(16),
            ColumnCount = 1,
        };
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 76));
        grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
        Add(grid, Label(UiText.ClientName + " *"), 0);
        Add(grid, _name, 1);
        Add(grid, Label(UiText.ClientSurname), 2);
        Add(grid, _surname, 3);
        Add(grid, Label(UiText.ClientPhone + " *"), 4);
        Add(grid, _phone, 5);
        Add(grid, Label(UiText.ClientPhone2), 6);
        Add(grid, _phone2, 7);
        Add(grid, Label(UiText.ClientNotes), 8);
        Add(grid, _notes, 9);
        Add(grid, _error, 10);

        var buttons = new FlowLayoutPanel
        {
            Dock = DockStyle.Bottom,
            FlowDirection = FlowDirection.RightToLeft,
            Height = 52,
            Padding = new Padding(12, 8, 12, 8),
        };
        var save = Theme.Command(UiText.SaveClient, Theme.Accent, 140);
        var cancel = Theme.Command(UiText.Cancel, Color.FromArgb(90, 98, 110), 120);
        save.Click += (_, _) => Save();
        cancel.Click += (_, _) => { DialogResult = DialogResult.Cancel; Close(); };
        buttons.Controls.Add(save);
        buttons.Controls.Add(cancel);
        Controls.Add(grid);
        Controls.Add(buttons);
        AcceptButton = save;
        CancelButton = cancel;
        Shown += (_, _) => (name.Length == 0 ? _name : _phone).Focus();
    }

    private void Save()
    {
        var name = _name.Text.Trim();
        var phone = _phone.Text.Trim();
        if (name.Length == 0)
        {
            _error.Text = UiText.NeedClientName;
            _name.Focus();
            return;
        }

        if (phone.Count(char.IsDigit) < 3)
        {
            _error.Text = UiText.NeedClientPhone;
            _phone.Focus();
            return;
        }

        Client = new ClientInfo
        {
            Kod = 0,
            Name = name,
            Surname = _surname.Text.Trim(),
            Phone = phone,
            Phone2 = _phone2.Text.Trim(),
            Notes = _notes.Text.Trim(),
        };
        DialogResult = DialogResult.OK;
        Close();
    }

    private static Label Label(string text) => new()
    {
        Text = text,
        Dock = DockStyle.Fill,
        TextAlign = ContentAlignment.BottomLeft,
        Font = Theme.UiBold,
        ForeColor = Theme.Header,
    };

    private static void Add(TableLayoutPanel grid, Control control, int row)
    {
        control.Dock = DockStyle.Fill;
        control.Margin = new Padding(0, 2, 0, 2);
        grid.Controls.Add(control, 0, row);
    }
}
