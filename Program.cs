// ============================================================
//  Aufgabe: Programmablaufplan – BMI-Rechner
//  Fach:    C# Grundlagen
//  Name:    [DEIN NAME HIER]
//  Datum:   [DATUM HIER]
// ============================================================
// TEST ZUM TESTEN :)
// AUFGABE 1 – Beantworte folgende Fragen hier als Kommentar:
//
// Frage 1: Wie viele Entscheidungsknoten (Rauten) hat der PAP?
// Antwort: 6
//
// Frage 2: Unter welchen Bedingungen endet das Programm frühzeitig?
// Antwort:   erster tryparse geht nein weg
//
// Frage 3: Warum wird TryParse statt Convert.ToDouble() verwendet?
// Antwort: weil TryParse kein Programm absturz verursacht wenn man was falsches eingibt
//
// Frage 4: Welchen Datentyp sollen gewicht und groesse haben, und warum?
// Antwort:  double wegen komma
//
// ============================================================

// TODO: Schreibe dein Programm unterhalb dieser Zeile.
//       Orientiere dich dabei am PAP in der README.md.
//       Jeder Schritt im PAP sollte einer Zeile / einem Block in deinem Code entsprechen.
Console.WriteLine("╔══════════════════════════════════╗");
Console.WriteLine("║        BMI - Rechner v1.0        ║");
Console.WriteLine("╚══════════════════════════════════╝");
double gewicht = -1, größe = -1, bmi = -1;
Console.Write("Bitte Namen eingeben:");
string name = Console.ReadLine();
Console.Write("Bitte Gewicht eingeben:");
string stringgewicht = Console.ReadLine();
bool gewichtBool = double.TryParse(stringgewicht, out gewicht); // gewicht eingabe
if (gewichtBool == true)
{
    Console.Write("Bitte größe in Meter eingeben:");
    bool größeBool = double.TryParse(Console.ReadLine(), out größe); // größe eingabe
    if (größeBool == true && größe >= 0) // Richtige eingabe und ist nicht 0
    {
        bmi = gewicht / (größe * größe); // bmi ausrechnen
        if (bmi < 18.5)
        {
            Console.WriteLine($"Hallo {name}, dein Bmi ist{bmi:F2} bei einer Größe von {größe}");
            Console.WriteLine($"BMI: Untergewicht");
        }
        else if (bmi < 25.0)
        {
            Console.WriteLine($"Hallo {name}, dein Bmi ist{bmi:F2} bei einer Größe von {größe}");
            Console.WriteLine("BMI:Normalgewicht");
        }
        else if (bmi < 30.0)
        {
            Console.WriteLine($"Hallo {name}, dein Bmi ist{bmi:F2} bei einer Größe von {größe}");
            Console.WriteLine("BMI:Übergewicht");
        }
        else
        {
            Console.WriteLine($"Hallo {name}, dein Bmi ist{bmi:F2} bei einer Größe von {größe}");
            Console.WriteLine("BMI:Starkes Übergewicht");
        }
    }
    else
    {
        Console.WriteLine("Fehler - Größe muss postiv sein"); // falsche eingabe nach größe
    }
}
else
{
    Console.WriteLine("Fehler - Ungültige Eingabe"); // falsche eingabe bei Meter
}

// ── Schritt 1: Programmtitel ausgeben ───────────────────────
// Tipp: Nutze Console.WriteLine() für die Titelbox.
// TODO: Ausgabe der Titelzeile (wie im Beispiel in der README)
Console.WriteLine("**Fach:**C# Grundlagen  \r\n");
Console.WriteLine(">**Thema:**Programmablaufplan(PAP) & Kontrollstrukturen");
Console.WriteLine("> **Schwierigkeit:** ⭐⭐ Mittel");
Console.WriteLine("> **Bearbeitungszeit:**ca. 90 Minuten");

// ── Schritt 2: Eingabe – Name ────────────────────────────────
// TODO: Benutzernamen einlesen (string, kein TryParse nötig)


// ── Schritt 3: Eingabe – Gewicht mit Validierung ─────────────
// TODO: Gewicht als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)


// ── Schritt 4: Eingabe – Größe mit Validierung ───────────────
// TODO: Körpergröße als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)
// TODO: Zusätzlich prüfen: Ist die Größe größer als 0?
//       Falls nicht → eigene Fehlermeldung und Programm beenden (return)


// ── Schritt 5: BMI berechnen ─────────────────────────────────
// Formel: BMI = Gewicht / (Größe * Größe)
// TODO: BMI berechnen und in einer Variablen speichern


// ── Schritt 6: Kategorie bestimmen ───────────────────────────
// TODO: Erstelle eine string-Variable "kategorie"
// TODO: Bestimme die Kategorie über eine if-else-if-Kette:
//       BMI < 18.5        → "Untergewicht"
//       BMI < 25.0        → "Normalgewicht"
//       BMI < 30.0        → "Übergewicht"
//       sonst (else)      → "Starkes Übergewicht"
//
// 💭 Denkfrage: Warum reicht bei "Normalgewicht" die Bedingung BMI < 25.0 aus,
//               obwohl laut WHO-Tabelle auch BMI >= 18.5 gelten muss?
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  Weil es mit > 18.5 auch abgedeckt ist und noch ein < 30 folgt. somit ist alles abgedeckt wie es die WHO vorgibt

// ── Schritt 7: Ergebnis ausgeben ─────────────────────────────
// TODO: Gib Name, BMI (auf 2 Dezimalstellen) und Kategorie formatiert aus
// Tipp: Nutze z.B. $"{bmi:F2}" für 2 Nachkommastellen
