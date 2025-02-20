### Person
Schrijf een klasse `Person` met de volgende eigenschappen:
- `FirstName` (string)
- `LastName` (string)
- `DateOfBirth` (DateTime)
- `IsMan` (boolean)
### Transaction
Schrijf een klasse `Transaction` met de volgende eigenschap:
- `Amount` (double) - Let op - Zorg er voor dat deze waarde altijd wordt afgerond op twee cijfers na de komma wanneer een waarde wordt toegewezen met de setter.

Schrijf een constructor voor `Transaction` met één parameter: Amount.

### BankAccount
Schrijf een klasse `BankAccount` met de volgende eigenschappen:
- `Owner` (Persoon)
- `AccountNumber` (string)
- `Transaction` (List van Transaction) - Let Op: Zorg er voor dat deze lijst altijd geïnitialiseerd is met een lege List bij het aanmaken van een nieuwe instantie.

Schrijf de volgende methodes:
- `void AddTransaction(Transaction transactie)`: Voegt een transactie toe.
- `double Saldo()`: Geeft het huidige saldo. Bereken dit door alle bedragen van elke transactie met elkaar op te tellen.

### Bank
Schrijf een klasse `Bank` met de volgende eigenschappen:
- `Customers` (List van BankAccount) - Let Op: Zorg er voor dat deze lijst altijd geïnitialiseerd is met een lege List bij het aanmaken van een nieuwe instantie.
- `Name` (string)

Schrijf de volgende methodes:
- `List<string> GetAllCustomers()`: Geeft een lijst met klantennamen.
- `void AddCustomer(BankAccount account)`: Voegt een nieuwe klant toe.
- `double ShowBankCapital()`: Geeft het totale saldo van de bank.

> [!NOTE]
> Bonusopdracht:
- Voeg validatie toe zodat `AccountNumber` altijd begint met "BE" en exact 12 cijfers bevat.
- Voeg een eigenschap `Type` toe aan de class `Transaction` die een D (Debet = geld storten) of C (credit = geld afhalen) bevat. 
- Voeg een `ToString()` methode toe aan `BankAccount` die de eigenaar en het saldo weergeeft.
