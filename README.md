Programul permite unui user sa inchirieze carti dintr o biblioteca si acestea pot sa aiba sau nu o data de retur. 
Adminul are control asupra tuturor cartilor, utilizatorilor si tipurilor de carti imprumutate si spoate shimba toti parametrii.
Exista clasa Book (carte individuala) si Books(tipul de carte exemlu: Ion de Liviu Rebreanu ) care are mai multe exemple de tipul Book.
Books are caracterristici comune cu Book, cum ar fi nume, autor, gen literar, si Guid, diferit pentru fiecare element.
User si admin au caracteristici comune, cum ar fi nume, parola  Guid, diferit pentru fiecare element.
Am implementat interfete pentru fiecare clasa din Models pentru simplificarea  codului.
Elementele din Folderul Dto sunt folosite pentru a afisa pe pagina web o versiune simplificata a codului din spatele programului
Tot in Business Layer Avem interfete pentru metodele folosite in Presentation Layer si clasele care implementeaza direct metodele respective si interfetele.
Presentation Layer ul are Controllere pentru fiecare din clasele din Data AccesLayer, controllerele implementeaza metodele din business layer si comunica cu Swagger APi ul
Am implementat operatiile CRUD pentru fiecare clasa Book, Books, Adnim, User;




