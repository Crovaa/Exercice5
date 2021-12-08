<a name='assembly'></a>
# Exercice_5

## Contents

- [Livre](#T-Exercice_5-Livre 'Exercice_5.Livre')
  - [ArracherDesPages(nombrePage)](#M-Exercice_5-Livre-ArracherDesPages-System-Int32- 'Exercice_5.Livre.ArracherDesPages(System.Int32)')
  - [ToString()](#M-Exercice_5-Livre-ToString 'Exercice_5.Livre.ToString')

<a name='T-Exercice_5-Livre'></a>
## Livre `type`

##### Namespace

Exercice_5

##### Summary

Cette classe est utilisé pour un exemple de documentation.

```
Livre livre = new Livre();
livre.ArracherDesPages(4);
```

<a name='M-Exercice_5-Livre-ArracherDesPages-System-Int32-'></a>
### ArracherDesPages(nombrePage) `method`

##### Summary

Cette méthode permet d'arracher des pages à un livre.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nombrePage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Définit le nombre de page arracher du livre. |

<a name='M-Exercice_5-Livre-ToString'></a>
### ToString() `method`

##### Summary

Cette méthode écrase le .ToString() de base par une string de Titre et Nom_Auteur du livre.

##### Returns

Retourne le titre du livre et nom de l'auteur.

##### Parameters

This method has no parameters.
