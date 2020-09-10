---
marp: true
---

# Module : La phase de tests et d'intégration - IMDW275

17 Décembre 2019 - Gaël Fenet-Garde - Gembasher Studio

---

# Présentation de l'intervenant

Gaël Fenet-Garde

Développeur indépendant et plus récemment fondateur de Gembasher Studio (gembasher.com)

gael.fenetgarde@campus-igs-toulouse.fr 

(envoi des rapports de tp à cette adresse si mon accès beecome n'est pas réparé)

---

# Prérequis logiciels : 

Le TP se fait en c# en utilisant le framework open source .NET Core 3.1.100

J'ai arbitrairement choisie la bibliothèque de tests xUnit afin de gagner du temps par rapport à l'écriture de tests manuels uniquements et parcequ'elle est nativement incluse dans .net core.

Je vous encourage à utiliser le même environnement que moi : VisualStudio Code qui est un editeur open source proposé par Microsoft pour le language C#.

Compte tenu de la lourdeur des modifications de code, il est vivement recommandé d'utiliser [git](https://git-scm.com/downloads). Téléchargez le avant de faire la suite des installation pour que VS Code l'intègre automatiquement à son interface.

---

# Prérequis logiciels : 

Commencez par télécharger [le SDK pour framework .NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-3.1.100-windows-x64-installer) et installez le.

[Pour ceux qui ne sont pas sous windows64.](https://dotnet.microsoft.com/download/dotnet-core/3.1)

Ensuite [téléchargez](https://code.visualstudio.com/download) et installez VS Code.

---

# Objectifs du module

Point sur les différents objectifs regroupés

Ces objectifs sont les vôtres (notation diplôme)

Leur véritable ampleur dépasse le cadre de ce cours (voir 'aller plus loin')

---

## Connaissance de la place et de l'impact des tests dans le cycle de vie du projet

---

## Connaissance des différents types de tests

## Séparer tests unitaires et tests d’intégration

---

## Connaissance de la phase d'intégration

---

## Environnement de test, de bases de données et logiciels

---

## Préparer et exécuter les plans de tests d’une application

## Rédaction du plan de test en utilisant les supports appropriés

## Rédaction du dossier de compte rendu de tests

---

# Organisation du module

3 jours de cours.

Aujourd'hui un petit cours d'introduction, l'installation du logiciel et la première partie du TP. 

Le reste du module sera une succession de TP avec quelques interventions théoriques.

---

8 Septembre 2020
9 Septembre 2020
10 Septembre 2020


---

# Contenu du module

L'objectif du module vas être de vous faire écrire une grande quantité de tests de plusieurs sortes et de vous familiariser avec les tests unitaires en c#.

---

# Pour aller plus loin

Je suis une mauvaise source théorique. Quelques très bonnes sources reconnues à la fois sur le plan théorique et pratique qui vont mènerons bien plus loin :

---

# Quelques auteurs

Kent Beck (Inventeur du Test-Driven Developpment et la méthode Xtrem Programming, inventeur de Junit)
Test Driven Development : By Example
Extreme Programming Explained : Embrace Change

---

# Quelques auteurs

Martin Fowler (Extreme Programming avec Kent Bent, également un gourou de l'agilité en général et blogeur prolifique)
Refactoring: Improving the Design of Existing Code.

---

# Quelques auteurs

Steve McConnell’s 
Code Complete 2

---

# Quelques auteurs

Robert C. Martin, inventeur méthodologie agile, blogueur (Uncle bob)
Coder proprement

---

# Modalité d'évaluation


---


## TP Standard

Vous allez rédiger pendant le module un rapport sur ce que vous faites (n'importe quel traitement de texte, faites moi un export pdf).

Différentes questions vous seront posées, vous devrez y répondre par écrit.

Lorsque des morceaux de code vous seront demandez, vous prendrez des screenshot du code, les découperez pour les rendre le plus clair possible.
Attention aux colorations syntaxiques exotiques et à l'orthographe. Des Malus serons appliqués : pas besoin de produire un document très estéhtique mais produisez quelque chose de clair et lisible, avec toutes les informations importantes pour moi dessus, n'éhsitez pas à me les demander.

En fonction de mon accès à Beecome, lorsque ca vous sera demandé, soit vous le déposerez sur la boite à livrable, sois vous enverrez un mail contenant vore rapport et une archive du code à l'adresse :
gael.fenetgarde@campus-igs-toulouse.fr

---

## Examen de rattrapage

L'examen de rattrapage sera un questionnaire standard, avec des questions du même ordre que celles du TP noté sur 20.

Le même malus sur l'orthographe sera appliqué.

---

# Communication

Vous pouvez communiquer avec moi par email : gael.fenetgarde@campus-igs-toulouse.fr

---

# Notes pour la soutenance

- Orthographe rapport
- Notation grille de compétences
- Mise en oeuvre de compétences via le stage (à vous de vous investir)
- Révisez la pratique et fournir de la matière : les tests sont un sujet facile, donnez des exemples

---

# Rédaction des rapports de TP

Objet du mail : votre promo / IMWD275 / numéro du tp / Nom de famille suivi du prénom

Rapports au format PDF, mettez également une archive du code en pièce jointe

---

# TP 1 : Concevoir des tests

Note : toutes les réponses sont à faire en pseudocode (ou langage naturel) ou en c#.

Exemple de pseudocode :

fonction EstInferieurADix( nombreAEvaluer entier) retourne boolean {
    SI nombreAEvaluer < 10 ALORS
        retourner VRAI
    SINON
        retourner FAUX
    FINSI
}

Les assertions :

Tout test (unitaire en particulier mais plus généralement) repose sur les assertion.

Une assertion est une affirmation qui doit être vérifiée pour que le teste réussisse ou échoue.

Les oracles :

L'oracle de test (appellé généralement oracle) est le mécanisme d'un test (automatisé ou non) qui vérifie l'assertion et donc fait échouter ou réussir le test.

Dans le cadre du tp utilisez les oracles suivantes que vous pouvez appeller comme des methodes :

VerifierEgalite( valeurA, valeurB )
VerifierEstVraie( expression )
VerifierEstFausse( expression )
VerifierProvoqueUneExeptionEgalite( appelDeMethode, typeDExeptionLevée )

Exemple de case de tests pour la fonction EstInferieurADix :

EstInferieurADix( 9999 ) doit retourner faux
EstInferieurADix( 10 ) doit retourner faux
EstInferieurADix( 8 ) doit retourner vrai
EstInferieurADix( -12 ) doit retourner vrai

Exemples d'implantations en pseudocode :

TEST EstInferieurADix_EntierPositifElevé {
    VerifierEgalite(EstInferieurADix(9999), faux)
}

TEST EstInferieurADix_EntierNegatif {
    VerifierVrai(EstInferieurADix(-8))
}

---

Précision : pour toutes les questions de cette partie du tp, je considère que vous utilisez un language typé, il n'est donc pas utile de tester les variantes d'erreur de saisie de type :

Soustraire(12,"TOTO")

---

# Q1



Méthode Soustraire(A,B) (retourne la valeur de A-B)

Écrire 25 tests unitaire pour cette méthode en essayant de couvrir un maximum de cas.

---

# Q2

Est-il possible de couvrir tous les cas de figure ? Si oui comment, si non pourquoi ?

---

# Q3

Méthode Additionner(A,B) (retourne la valeur de A+B)

Écrire un panel de tests unitaire pour cette méthode en essayant d'être exaustif.

---

# Q4

Méthode Diviser(A,B) (retourne la valeur de A/B)

## Q4a

Écrire un panel de tests unitaire pour cette méthode en essayant d'être exaustif.

## Q4b
Quels est la particularité de cette méthode par rapport aux précédentes ?

## Q4c

Cela la rend elle moins testable ? Si oui pourquoi ? Sinon comment la tester ?

---

# Q5

Méthode Multiplier(A,B) (retourne la valeur de A*B)

écrire un panel de tests unitaire pour cette méthode en essayant d'être exaustif.

---

# Q6

Écrire un programme qui affiche les nombres de 1 à 199. Mais pour les multiples de 3, afficher “Fizz” au lieu du nombre et pour les multiples de 5 afficher “Buzz”. Pour les nombres multiples de 3 et 5, afficher “FizzBuzz”.

## Q6a 

Écrire un test pour le programme vérifiant que celui est bon

## Q6b 

Écrivez le programme FizzBuzz. Il doit comporter une méthode principale et au moins une méthode interne qui prends en paramètre un nombre et retourne une chaine de caracteres.

---

## Q6c 

Écrire un pannel de tests unitaire pour la méthode interne en essayant de couvrir un maximum de cas.

## Q6d 

Est-il possible d'écrire un test qui teste tous les cas possibles pour la méthode interne ? L'a t'on fait ? Développer pourquoi en quelques phrases.

---

# Q7

Un site Web Comporte 3 pages, HOME, PAGE 1, PAGE 2. Lorsque une mauvaise url sur le bon domaine est entrée, le navigateur est redirigé vers la page HOME.

## Q7a

Proposer un test automatisable vérifiant que chaque page est en ligne et que l'ont peut aller avec un lien de Home a page 1, de page 1 à page 2, et des pahes 1 et 2 vers home. 

## Q7b

Proposer au moins un test verifiant que la redirection marche bien.

---

# Q8

Une classe Personne possède un attribue de type entier représentant son âge en année. Il existe une methode Veillir(entier nombreAnnee) qui permet de faire veillir une personne mais jamais rajeunir. 

Écrire un panel de tests unitaire pour cette méthode en essayant de couvrir un maximum de cas.

---

# Q9

Une classe Elfe possède un attribue de type entier représentant son âge en année. Elle possède également un attribu de type booléen EtreEnStase.
Un Elfe nouvellement créee à forcément un age valant zero et ne nais jamais en stase. 
En plus de la méthode Veillir(entier) il existe une méthode Rajeunir(entier) qui à le fonctionnement inverse.
Il existe également une méthode EntrerEnStase() qui comme son nom l'indique fait rentrer l'elfe en stase. Il existe également une méthode SortirDeStase() qui permet d'en sortir.
Un elfe en état de stase ne peux plus veillir ou rajeunir.
Une fois qu'un elfe atteinte 999 ans, il atteint l'état de stase et ne peux plus en sortir.

Proposez un ensemble de tests qui d'après vous permette de garantir le bon fonctionnement de la classe Elfe et de ses méthodes.

---

# Q10

Choisissez un jeu vidéo (si possible quelque chose que je connaisse) et imaginez que vous soyez charger de garantir la non regression du jeu pour les développement à venir. 
Proposer un plan de tests le plus large possible en essayant d'atteindre le plus de domaines possibles. Vous pouvez au choix proposer des scénario longs ou des scénarios courts plus nombreux.

---

# Q11

Ecrivez en c# une classe CalculatorTest correspondant aux tests que vous avez imaginés dans les question Q1 à Q4.
Puis implantez une classe Calculator répondant à ces tests.

---

# Q12

Même travail pour la questions Q8 : écrivez les tests puis implantez la classe Personne.

---

# Q13

Même travail pour la questions Q9 : écrivez les tests puis implantez la classe Elfe.

---

Relisez votre rapport et envoyez le à gael.fenetgarde@campus-igs-toulouse.fr

Précisez vos nom prénom, adresse mail, le sujet du cours et votre promotion.

Merci :)