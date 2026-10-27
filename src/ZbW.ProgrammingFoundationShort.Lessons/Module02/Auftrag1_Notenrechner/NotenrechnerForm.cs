namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

// ============================================================
// AUFTRAG 1 – Notenrechner (⭐ Einfach | ~15 Min.)
//
// Berechne eine Note anhand von Punkten mittels if/else-Kette.
//
// Anforderungen:
//   - TxtPunkte: Punktezahl (0–100) einlesen
//   - if/else-Kette:
//       90–100 → Note 6 / "Sehr gut"
//       75–89  → Note 5 / "Gut"
//       60–74  → Note 4 / "Genügend"
//       < 60   → Note 3 / "Ungenügend"
//   - Ergebnis in LblNote und LblBewertung anzeigen
// ============================================================

public partial class NotenrechnerForm : Form
{
  public NotenrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // TODO 1: Punkte aus TxtPunkte lesen (int.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return
    if (!int.TryParse(TxtPunkte.Text.Trim(), out int input) || input <= 0 || input > 100)
    {
      MessageBox.Show("Ungültige Eingabe");
      return;
    }

    int make;
    string rating;

    if (input >= 90)
    {
      make = 6;
      rating = "Sehr gut";
    } else if (input >= 75)
    {
      make = 5;
      rating = "Gut";
    } else if (input >= 60)
    {
      make = 4;
      rating = "Genügend";
    } else
    {
      make = 3;
      rating = "Ungenügend";
    }


    // TODO 2: if/else-Kette für Noten
    //         90-100 → Note 6 / "Sehr gut"
    //         75-89  → Note 5 / "Gut"
    //         60-74  → Note 4 / "Genügend"
    //         < 60   → Note 3 / "Ungenügend"

    // TODO 3: LblNote.Text und LblBewertung.Text setzen

    LblNote.Text = $"{make}";
    LblBewertung.Text = rating;
  }
}
