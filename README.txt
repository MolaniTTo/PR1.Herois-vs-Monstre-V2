FUNCIO MENU:

Classes d'Equivalència:

Classe 1: choose igual a 0 o 1.
Classe 2: choose menor que 0 o major que 1.
Valors Límit:

Límit Inferior (LI): choose igual a 0.
Límit Superior (LS): choose igual a 1.
Casos de Prova:

Cas 1: choose igual a 0 (dins del rang, hauria de retornar 0).
Cas 2: choose igual a 1 (dins del rang, hauria de retornar 1).
Cas 3: choose menor que 0 (fora del rang, deuria decrementar intents i demanar un nou valor).
Cas 4: choose major que 1 (fora del rang, deuria decrementar intents i demanar un nou valor).
Cas 5: Esgotar els intents (intents igual a 0, hauria de retornar el nombre d'intents restants).



FUNCIO NOMS:

Classes d'Equivalència:

Classe 1: Longitud del array personatges igual a 4, i cada element no és nul o cadena buida.
Classe 2: Longitud del array personatges diferent de 4.
Classe 3: Almenys un element en personatges és nul o una cadena buida.
Valors Límit:

Límit Inferior (LI): Longitud del array personatges igual a 4, i cada element no és nul o cadena buida.
Límit Superior (LS): Longitud del array personatges diferent de 4.
Casos de Prova:

Cas 1: Longitud del array personatges igual a 4, i cada element no és nul o cadena buida (dins del rang, hauria de retornar el array modificat).
Cas 2: Longitud del array personatges diferent de 4 (fora del rang, hauria de demanar nous noms fins a aconseguir la longitud desitjada).
Cas 3: Almenys un element en personatges és nul o una cadena buida (fora del rang, hauria de demanar un nou nom per a l'element afectat).



FUNCIO DIFICULTSELECTOR:

Classes d'Equivalència:

Classe 1: dificultat igual a 1, 2, 3 o 4.
Classe 2: dificultat menor que 1 o major que 4.
Valors Límit:

Límit Inferior (LI): dificultat igual a 1.
Límit Superior (LS): dificultat igual a 4.
Casos de Prova:

Cas 1: dificultat igual a 1 (dins del rang, hauria de retornar 1).
Cas 2: dificultat igual a 2 (dins del rang, hauria de retornar 2).
Cas 3: dificultat igual a 3 (dins del rang, hauria de retornar 3).
Cas 4: dificultat igual a 4 (dins del rang, hauria de retornar 4).
Cas 5: dificultat menor que 1 (fora del rang, deuria decrementar intents i demanar un nou valor).
Cas 6: dificultat major que 4 (fora del rang, deuria decrementar intents i demanar un nou valor).
Cas 7: Esgotar els intents (intents igual a 0, hauria de retornar el nombre d'intents restants).



FUNCIO PERSONALIZED:

Classes d'Equivalència:
Per a cada conjunt de paràmetres (VidP, AtaP, RedP) en les funcions Personalized:

Classe 1: Valors dins del rang especificat (vidaMin a vidaMax per a VidP, ataqueMin a ataqueMax per a AtaP, reduccionMin a reduccionMax per a RedP).
Classe 2: Valors fora del rang especificat (menor que vidaMin o major que vidaMax per a VidP, menor que ataqueMin o major que ataqueMax per a AtaP, 
menor que reduccionMin o major que reduccionMax per a RedP).
Valors Límit:

Límit Inferior (LI) i Límit Superior (LS): Els límits específics per a cada paràmetre (vidaMin, vidaMax, ataqueMin, ataqueMax, reduccionMin, reduccionMax).
Casos de Prova:

Cas 1: Valors dins del rang especificat per a VidP, AtaP i RedP (dins del rang, hauria de mantenir els valors proporcionats).
Cas 2: Valors fora del rang especificat per a VidP, AtaP i RedP (fora del rang, hauria de demanar nous valors fins a aconseguir valors vàlids).
Cas 3: Esgotar els intents per a VidP, AtaP i RedP (intents igual a 0, hauria d'establir el valor mínim permès).
La funció Personalized que anomena a Personalized repetidament s'executa per a cada conjunt de paràmetres
(VidP1, VidP2, VidP3, VidP4, VidM, AtaP1, AtaP2, AtaP3, AtaP4, AtaM, RedP1, RedP2, RedP3, RedP4, RedM), i els casos de prova s'apliquen 
de manera similar als valors específics proporcionats en l'anomenada a la funció.



FUNCIO BATALLA: 

Classes d'Equivalència:
Per a cada conjunt de paràmetres en les funcions Batalla:

Classe 1: Personatges i monstre amb vida positiva (VidP1, VidP2, VidP3, VidP4, VidM majors que 0).
Classe 2: Almenys un personatge mort (VidP1, VidP2, VidP3, VidP4 menor o igual a 0).
Classe 3: Monstre derrotat (VidM igual a 0).
Valors Límit:

Límit Inferior (LI): Vida del monstre (VidM) igual a 0.
Límit Superior (LS): Vida dels personatges i monstre major que 0.
Casos de Prova:

Cas 1: Personatges i monstre amb vida positiva (hauria de continuar la batalla).
Cas 2: Almenys un personatge mort (hauria de deixar de batallar).
Cas 3: Monstre derrotat (hauria de deixar de batallar).
La funció Batalla realitza una sèrie d'accions en cada torn. Per tant, els casos de prova haurien de
provar diferents situacions en la batalla, incloent-hi atacs, defenses i habilitats especials. No obstant això,
la funció és bastant extensa i es necessitaria una revisió més detallada per a definir casos de prova específics.



FUNCIO PERSONATGEVIU:

Classes d'Equivalència:

Classe 1: Vida positiva per al personatge seleccionat (VidP1, VidP2, VidP3, VidP4 major que 0).
Classe 2: Vida igual o menor que 0 per al personatge seleccionat (VidP1, VidP2, VidP3, VidP4 igual o menor que 0).
Classe 3: Personatge no trobat en el array proporcionat.
Valors Límit:

Límit Inferior (LI): Vida del personatge (VidP1, VidP2, VidP3, VidP4) igual a 0.
Límit Superior (LS): Vida del personatge (VidP1, VidP2, VidP3, VidP4) major que 0.
Casos de Prova:

Cas 1: Vida positiva per al personatge seleccionat (hauria de retornar true).
Cas 2: Vida igual o menor que 0 per al personatge seleccionat (hauria de retornar false).
Cas 3: Personatge no trobat en el array proporcionat (hauria de retornar false).



FUNCIO DEFENSA:

Classes d'Equivalència:

Classe 1: Reducció de mal duplicada per al personatge seleccionat (RedP1, RedP2, RedP3, RedP4 multiplicats per 2).
Classe 2: Personatge no trobat en el array proporcionat.
Valors Límit:

Límit Inferior (LI): Reducció de mal igual a 0.
Límit Superior (LS): Reducció de mal major que 0.
Casos de Prova:

Cas 1: Reducció de mal duplicada per al personatge seleccionat (hauria de retornar la nova reducció de mal).
Cas 2: Personatge no trobat en el array proporcionat (hauria de retornar 0).



FUNCIO HABILITATESPECIAL:

Classes d'Equivalència:

Classe 1: Habilitat especial aplicada correctament per al personatge seleccionat (HB1, HB2, HB3, HB4 establerts correctament).
Classe 2: Personatge no trobat en el array proporcionat.
Valors Límit:

Límit Inferior (LI): Habilitat especial igual a 0.
Límit Superior (LS): Habilitat especial establerta correctament (5 per a cada personatge).
Casos de Prova:

Cas 1: Habilitat especial aplicada correctament per al personatge seleccionat (hauria de retornar el valor correcte de l'habilitat especial).
Cas 2: Personatge no trobat en el array proporcionat (hauria de retornar 0).



FUNCIO ATACCRITIC:

Classes d'Equivalència:

Classe 1: Valor de atacCritic generat aleatòriament dins del rang d'1 a 100.
Valors Límit:

Límit Inferior (LI): atacCritic igual a 1.
Límit Superior (LS): atacCritic igual a 100.
Casos de Prova:

Cas 1: Valor de atacCritic generat aleatòriament dins del rang d'1 a 100.



FUNCIO FALLARATAC:

Classes d'Equivalència:

Classe 1: Valor de fallarAtac generat aleatòriament dins del rang d'1 a 100.
Valors Límit:

Límit Inferior (LI): fallarAtac igual a 1.
Límit Superior (LS): fallarAtac igual a 100.
Casos de Prova:

Cas 1: Valor de fallarAtac generat aleatòriament dins del rang d'1 a 100.


