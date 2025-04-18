<H1>MORSEOVA ABECEDA</H1>
<h2>MorseCodeConversion</h2>

Program na konverziu textu na kód morseovej abecedy sa riadi <a href="#pravidla">štandardami a pravidlami</a> uvedenými nižšie.</br>
Pôvodne som konverziu skúšal riešiť pomocou polí <code>Array</code>. Postupne metódou pokusu a omylu som prešiel na <code>Dictionary</code> • kolekcia pre ukladanie dvojíc kľúč-hodnota</br>
Vyriešené je čítanie konvertovaného textu zo súboru <code>File</code> do <code>textBoxu1</code>, očistenie textu od diakritiky a niektorých bielych znakov a následná konverzia do Morseho kódu do <code>textBoxu2</code>. </br>
Len pre radosť som spravil ikonu programu :) Drobnosti občas potešia ... </br>

<h5>TO DO</h5>
<ul>
  <li>doriešiť funkčnosť menu <code>File</code> <code>New</code>[!!!] a <code>Save</code>[OK] + výnimky[OK]</li>
  <li>dokončiť v menu <code>Convert</code>  odkazy na konverziu + prehodiť metody z Program.cs do Form.cs</li>
  <li>archív v menu <code>View</code> ??? </li>
</ul>
<h4 id="pravidla">ŠTANDARDY a PRAVIDLÁ</h4>
1. Medzinárodný štandard vs. národné varianty
Morseova abeceda je medzinárodne štandardizovaná a väčšina krajín používa rovnaké kódy pre základné latinské písmená (A-Z) a číslice (0-9). Avšak:

2. Špeciálne slovenské znaky
Pre slovenské diakritické písmená (á, ä, č, ď, é, í, ĺ, ľ, ň, ó, ô, ŕ, š, ť, ú, ý, ž) neexistuje oficiálny medzinárodný Morseov kód. V praxi sa riešia takto:

Bez diakritiky: Najčastejšie sa nahradia základným písmenom (š → S, č → C)

Vojenský/spravodajský prenos: Niekedy sa používajú kombinácie:

Napr. Ž = ···−·· (pôvodne pre ruské "Ж")

Š = ···· (pôvodne pre ruské "Ш")

Telegrafné konvencie: V minulosti si niektoré krajiny vytvárali vlastné rozšírenia

3. Historický kontext
V Československu sa v minulosti (20. storočie) občas používali improvizované kódy pre diakritiku, ale nikdy neboli štandardizované.

4. Moderné použitie
Dnes sa v amatérskom rádiu a oficiálnej komunikácii:

Diakritika sa vynecháva

Ak je potrebné presné písanie, používa sa fonetický prepis:

"Ďakujem" → "DAKUJEM"

"Škola" → "SKOLA"
