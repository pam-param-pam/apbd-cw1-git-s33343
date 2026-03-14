Nie było fast-forward merge ponieważ oba branche miały niezależne zmiany i sie rozeszły.


1) Fast-forward będzie wtedy gdy branch docelowy nie ma żadnych nowych commitów od momentu utworzenia drugiego brancha
   Merge commit będzie gdy oba branche mają niezależne commity

2) Merge zachowuje pełną, nie liniową historie commitów łącząc ze sobą 2 branche.
   Rebase zachowuje liniową historie poprzez przeniesienie commitów z jednej gałęzi na koniec drugiej i chyba też przepisuje historie?

3) Konflikt pojawił sie bo 2 branche zmodifykowały ten sam fragment pliku. Został rozwiązany poprzez ręcznie wybranie którą wersje kodu chce sie wybrać