# 🧪 Testprotokoll – BMI-Rechner

**Name:** [DEIN NAME]  
**Datum:** [DATUM]  

---

## Testfälle

Führe alle Testfälle aus und notiere die tatsächliche Ausgabe deines Programms.

### TC-01 – Normalgewicht

| | |
|---|---|
| **Eingabe Name** | Max Mustermann |
| **Eingabe Gewicht** | 70 |
| **Eingabe Größe** | 1.75 |
| **Erwartete Kategorie** | Normalgewicht |
| **Tatsächliche Ausgabe** | *Hallo Max Mustermann, dein Bmi ist 0,00 bei einer Größe von 175
BMI: Untergewicht* |
| **✅ Bestanden?** | Nein |

---

### TC-02 – Untergewicht

| | |
|---|---|
| **Eingabe Name** | Lisa Beispiel |
| **Eingabe Gewicht** | 50 |
| **Eingabe Größe** | 1.70 |
| **Erwartete Kategorie** | Untergewicht |
| **Tatsächliche Ausgabe** | *Hallo Lisa Beispiel, dein Bmi ist 0,00 bei einer Größe von 170
BMI: Untergewicht |
| **✅ Bestanden?** | Nein |

---

### TC-03 – Übergewicht

| | |
|---|---|
| **Eingabe Name** | Tom Tester |
| **Eingabe Gewicht** | 95 |
| **Eingabe Größe** | 1.75 |
| **Erwartete Kategorie** | Übergewicht |
| **Tatsächliche Ausgabe** | *Hallo Tom Tester, dein Bmi ist 0,00 bei einer Größe von 175
BMI: Untergewicht* |
| **✅ Bestanden?** | Nein |

---

### TC-04 – Starkes Übergewicht

| | |
|---|---|
| **Eingabe Name** | Anna Admin |
| **Eingabe Gewicht** | 120 |
| **Eingabe Größe** | 1.75 |
| **Erwartete Kategorie** | Starkes Übergewicht |
| **Tatsächliche Ausgabe** | *Hallo Anna Admin, dein Bmi ist 0,00 bei einer Größe von 175
BMI: Untergewicht* |
| **✅ Bestanden?** | Nein |

---

### TC-05 – Fehlerfall: Ungültiges Gewicht

| | |
|---|---|
| **Eingabe Name** | Fehler-Test |
| **Eingabe Gewicht** | `abc` |
| **Eingabe Größe** | (entfällt) |
| **Erwartet** | Fehlermeldung, Programm endet |
| **Tatsächliche Ausgabe** | *Bitte Namen eingeben:Fehler-Test
Bitte Gewicht eingeben:abc
Fehler - Ungültige Eingabe* |
| **✅ Bestanden?** | Nein |

---

### TC-06 – Fehlerfall: Negative Größe

| | |
|---|---|
| **Eingabe Name** | Fehler-Test |
| **Eingabe Gewicht** | 70 |
| **Eingabe Größe** | -1 |
| **Erwartet** | Fehlermeldung (Größe ungültig), Programm endet |
| **Tatsächliche Ausgabe** | Fehler - Größe muss postiv sein |
| **✅ Bestanden?** |  Nein |

---

## 💭 Reflexionsfragen (Aufgabe 4)

### Frage 1
> Was passiert, wenn jemand `1,75` statt `1.75` als Größe eingibt? Teste es! Wie könnte man das Problem lösen?
das würde jede aufgabe richtig ausgeben :D da er den . löscht

**Beobachtung beim Test:**  
das alle mit . nicht funktionieren xD

**Mögliche Lösung:**  
, nutzen bei eingabe

---

### Frage 2
> Warum ist die Reihenfolge der `if-else-if`-Bedingungen wichtig? Was würde passieren, wenn du mit `BMI < 30` anfängst?

**Antwort:**  
So prüft er von groß nach klein und nicht von klein nach groß

---

### Frage 3
> Der PAP zeigt, dass `groesse > 0` **nach** TryParse geprüft wird. Warum macht diese Reihenfolge Sinn?

**Antwort:**  
weil erst überhaupt geprüft wird das etwas richtig eingeben wurde, und man das in der IF selbst prüfen kann

---

## Zusammenfassung

| Testfall | Bestanden? |
|----------|-----------|
| TC-01 | ⬜ |
| TC-02 | ⬜ |
| TC-03 | ⬜ |
| TC-04 | ⬜ |
| TC-05 | ⬜ |
| TC-06 | ⬜ |

**Bestandene Tests:** ___ / 6
