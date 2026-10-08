# Bits & Bites

Konsolenanwendung zur Verwaltung von Bestellungen für das Internetcafé **Bits & Bites**.

---

## Status

✅ Aufgabe 1 abgeschlossen

✅ Aufgabe 2 abgeschlossen

✅ Eingabevalidierung implementiert

✅ Git-Versionierung verwendet

---



Das Projekt wurde im Rahmen einer Übung zu den Themen:

- Objektorientierte Programmierung (OOP)
- Vererbung
- Polymorphie
- Abstrakte Klassen
- Collections (`List<T>`)
- Konsolenanwendungen
- Git und GitHub

entwickelt.

---

# Projektbeschreibung

Das Internetcafé **Bits & Bites** verkauft:

- Getränke
- Speisen
- zeitbasierte Internettickets

Mehrere Posten können zu einer Bestellung hinzugefügt werden.

Für unterschiedliche Postentypen gelten unterschiedliche Preisregeln:

- alkoholische Getränke in der Happy Hour erhalten Rabatt
- Speisen in Größe „Extra Groß“ erhalten Aufschlag
- Tickets werden nach Minutenpreis berechnet
- Besitzer einer Bits & Bites-Card erhalten 5 % Rabatt auf die gesamte Bestellung

---

# Projektstruktur

```text
BitsAndBites
│
├── Models
│   ├── Posten.cs
│   ├── Getraenk.cs
│   ├── Essen.cs
│   ├── Ticket.cs
│   └── Bestellung.cs
│
├── Services
│   └── KonsolenMenue.cs
│
├── Program.cs
└── README.md
```

---

# Architektur

Das Projekt verwendet eine einfache Schichtenaufteilung.

## Models

Enthält das Domänenmodell.

Die Klassen speichern Daten und führen Preisberechnungen aus.

**Keine Konsolenein- oder -ausgabe erfolgt in den Modelklassen.**

---

## Services

Enthält die Benutzeroberfläche.

Die Klasse `KonsolenMenue` übernimmt:

- Anzeige des Menüs
- Einlesen von Benutzereingaben
- Steuerung des Programmablaufs

---

## Program

Die Anwendung wird über `Program.cs` gestartet.

Dort wird ein Objekt der Klasse `KonsolenMenue` erzeugt und gestartet.

---

# Klassenbeschreibung

## Posten

Abstrakte Basisklasse für alle Bestellpositionen.

### Eigenschaften

```csharp
Name
Preis
```

### Methoden

```csharp
BerechnePreis()
```

Abstrakte Methode zur Berechnung des tatsächlichen Preises.

---

## Getraenk

Repräsentiert ein Getränk.

### Eigenschaften

```csharp
Alkoholisch
HappyHour
```

### Preisregel

Falls das Getränk alkoholisch ist und während der Happy Hour bestellt wurde:

```text
Preis × 0,75
```

Andernfalls gilt der Grundpreis.

---

## Essen

Repräsentiert eine Speise.

### Eigenschaften

```csharp
Extragross
```

### Preisregel

Bei Extra Groß:

```text
Preis + 20 %
```

Formel:

```text
Preis × 1,20
```

---

## Ticket

Repräsentiert einen Internetzugang.

### Eigenschaften

```csharp
Startzeit
Minuten
```

### Preisregel

```text
Minutenpreis × Minuten
```

---

## Bestellung

Verwaltet alle Bestellpositionen.

### Eigenschaften

```csharp
BitAndBiteCard
Bestellposten
```

### Methoden

```csharp
PostenHinzufuegen()
```

Fügt einen neuen Posten hinzu.

```csharp
BerechneBestellung()
```

Berechnet den Gesamtbetrag.

Bei aktiver Bits & Bites-Card wird ein Rabatt von 5 % gewährt.

---

## KonsolenMenue

Steuert die gesamte Benutzerinteraktion.

### Aufgaben

- Menü anzeigen
- Eingaben verarbeiten
- Posten erstellen
- Bestellung verwalten
- Bestellungen anzeigen
- Bestellungen übermitteln

---

# Verwendete OOP-Konzepte

## Vererbung

```csharp
Getraenk : Posten
Essen : Posten
Ticket : Posten
```

Alle Postentypen erben gemeinsame Eigenschaften von der Basisklasse `Posten`.

---

## Polymorphie

Die Bestellung speichert alle Positionen in einer Liste:

```csharp
List<Posten>
```

Dadurch können verschiedene Objekttypen gemeinsam verarbeitet werden.

---

## Abstrakte Klasse

```csharp
abstract class Posten
```

Die Klasse kann nicht direkt instanziiert werden.

Jede Unterklasse muss die Methode

```csharp
BerechnePreis()
```

selbst implementieren.

---

# Konsolenmenü

Die Anwendung bietet folgende Funktionen:

```text
1. Getränk hinzufügen
2. Essen hinzufügen
3. Internetticket hinzufügen
4. Posten entfernen
5. Bestellung anzeigen
6. Bits & Bites-Card an/aus
7. Bestellung an Theke übermitteln
8. Beenden
```

---

# Fehlerbehandlung

Zur Vermeidung von Programmabstürzen werden Benutzereingaben validiert.

Verwendete Methoden:

```csharp
decimal.TryParse()
int.TryParse()
```

Ungültige Eingaben führen zu einer erneuten Abfrage statt zu einer Exception.

---

# Besondere Funktionen

## Flexible Preiseingabe

Folgende Eingaben werden unterstützt:

```text
8,5
```

und

```text
8.5
```

---

## Vereinfachte boolsche Eingaben

Anstelle von

```text
true / false
```

kann der Benutzer eingeben:

```text
t = true
f = false
```

---

# Git-Workflow

Das Projekt wurde schrittweise entwickelt.

Für jeden abgeschlossenen Funktionsblock wurde ein eigener Git-Commit erstellt.

Beispiele:

- Projektstruktur erstellen
- Posten implementieren
- Getränk implementieren
- Essen implementieren
- Ticket implementieren
- Bestellung implementieren
- Konsolenmenü erstellen
- Getränk hinzufügen
- Essen hinzufügen
- Ticket hinzufügen
- Card-Funktion
- Bestellungen anzeigen
- Bestellungen übermitteln
- Eingabevalidierung

---
# Umgesetzte optionale Erweiterungen

Im Rahmen der Projektarbeit wurden zusätzlich einige optionale Erweiterungen aus der Aufgabenstellung umgesetzt.

---

## Konstanten statt magischer Zahlen

Zur Verbesserung der Lesbarkeit und Wartbarkeit des Quellcodes wurden sogenannte *magische Zahlen* durch sprechend benannte Konstanten ersetzt.

### Vorher

```csharp
0.75m
1.20m
0.95m
```

Die Bedeutung dieser Werte war nur durch Nachvollziehen der Berechnungen erkennbar.

### Nachher

```csharp
private const decimal HappyHourRabatt = 0.75m;
private const decimal ExtraGrossFaktor = 1.20m;
private const decimal CardRabatt = 0.95m;
```

### Vorteile

- bessere Lesbarkeit des Codes
- zentrale Verwaltung wichtiger Werte
- einfachere Wartung
- Clean-Code-Prinzipien werden besser eingehalten

### Beispiele

Happy-Hour-Rabatt:

```csharp
return decimal.Round(
    Preis * HappyHourRabatt,
    2);
```

Extra-Groß-Aufschlag:

```csharp
return decimal.Round(
    Preis * ExtraGrossFaktor,
    2);
```

Card-Rabatt:

```csharp
gesamtbetrag *= CardRabatt;
```

Durch die Verwendung benannter Konstanten ist sofort ersichtlich, welche Bedeutung die jeweiligen Werte besitzen.

---

## Berechnete Ticket-Endzeit

Für die Klasse `Ticket` wurde eine zusätzliche berechnete Property `Endzeit` implementiert.

### Implementierung

```csharp
public DateTime Endzeit
{
    get
    {
        return Startzeit.AddMinutes(Minuten);
    }
}
```

### Funktionsweise

Die Endzeit wird automatisch aus der Startzeit und der Ticketdauer in Minuten berechnet.

### Beispiel

```text
Startzeit: 14:00
Dauer: 60 Minuten
Endzeit: 15:00
```

### Vorteile

- keine doppelte Datenspeicherung
- automatische Aktualisierung
- keine manuelle Berechnung erforderlich
- jederzeit korrekte Endzeit

### Anzeige im Bon

Bei der Anzeige einer Bestellung und bei der Übermittlung an die Theke werden die zusätzlichen Ticketinformationen ausgegeben.

Beispiel:

```text
Kurzticket - 3,00 €

Start: 14:00
Ende: 15:00
```

Dadurch erhält der Benutzer zusätzliche Informationen über die Gültigkeitsdauer des Tickets.