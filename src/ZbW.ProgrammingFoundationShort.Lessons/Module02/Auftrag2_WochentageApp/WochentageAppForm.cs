namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp;

// ============================================================
// AUFTRAG 2 – WochentageApp (⭐⭐ Mittel | ~30 Min.)
//
// Zeige Infos zum gewählten Wochentag.
//
// Anforderungen:
//   - CmbWochentag: ComboBox mit Mo, Di, Mi, Do, Fr, Sa, So
//   - switch expression: Werktag oder Wochenende? ("Samstag" or "Sonntag" → Wochenende)
//   - Ternärer Operator für den Ausgabetext
//   - LblErgebnis: Wochentag + Typ anzeigen, z. B. "Samstag ist ein Wochenende."
// ============================================================

public partial class WochentageAppForm : Form
{
  public WochentageAppForm()
  {
    InitializeComponent();
    // TODO 1: ComboBox-Items befüllen: "Montag","Dienstag","Mittwoch","Donnerstag","Freitag","Samstag","Sonntag"
    //         CmbWochentag.SelectedIndex = 0;
    Enum.GetValues<WeekDay>()
      .ToList()
      .ForEach((day) => CmbWochentag.Items.Add(day));
    CmbWochentag.SelectedIndex = 0;
  }

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    // TODO 2: Gewählten Tag aus CmbWochentag lesen (CmbWochentag.Text)
    string selectedInput = CmbWochentag.Text;
    WeekDay selectedEnumInput = Enum.Parse<WeekDay>(selectedInput);

    bool isWorkday = selectedEnumInput switch
    {
       WeekDay.Samstag or WeekDay.Sonntag => false,
        _ => true,
    };

    string type = isWorkday ? "Werktag" : "Wochenende";

    LblErgebnis.Text = type;

    // TODO 3: switch expression → bool istWerktag
    //         ("Samstag" or "Sonntag" → false, sonst true)

    // TODO 4: Ternären Operator → "Werktag" oder "Wochenende"
    //         string typ = istWerktag ? "Werktag" : "Wochenende";

    // TODO 5: LblErgebnis.Text setzen
  }
}
