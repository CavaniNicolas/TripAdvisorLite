# TripAdvisorLite

Pour lancer le site:

1 - Lancer la WebApplication (folder ProjetTripAdvisor) dans VisualStudio (cliquer sur 'IIS Express')  
Si ça dit l'erreur ```Unable to connect to webserver IIS Express```, normalement c'est bon quand même.   
Il faut qu'il y ait écrit ```IIS Express is running``` dans la console

2 - Si c'est le premier lancement sur la machine, ```npm install``` dans le dossier 'frontend'.

3 - Lancer le frontend avec ```npm run start``` dans le dossier 'frontend'
	

Trucs à installer : 
- NodeJs
- Bootstrap: dans le repertoire frontend, taper ```import 'bootstrap/dist/css/bootstrap.css'```

- Si ça parle d'une erreur de DB avec Azure, donnez nous votre adresse IP pour qu'on vous ajoute.

- Si le site marche mais qu'il n'y a pas de données, F12. Si il y a des erreurs CORS, installer une plugin sur votre browser pour empecher les erreurs CORS.
- -Pour Chrome j'ai pris ça https://chrome.google.com/webstore/detail/moesif-origin-cors-change/digfbfaphojjndkpccljibejjbppifbc 
