﻿imaLiJaciModul.config([
    '$stateProvider', '$locationProvider', '$urlRouterProvider', function ($stateProvider, $locationProvider, $urlRouterProvider) {
    
        var imaLiJaciPublic = {
            name: 'imaLiJaciPublic',
            url: '/',
            controller: 'imaLiJaciPublic',
            templateUrl: '/Htmltemplates/imaLiJaciPublic.html'
        };

        var imaLiJaciTutorial= {
            name: 'imaLiJaciTutorial',
            url: '/tutorial',
            templateUrl: '/Htmltemplates/imaLiJaciTutorial.html'
        };

        var editProfile = {
            name: 'editProfile',
            url: '/profil/namazi',
            controller: 'editProfile',
            templateUrl: '/HtmlTemplates/editProfile.html'
        }
        $stateProvider.state(imaLiJaciPublic)
                      .state(imaLiJaciTutorial)
                      .state(editProfile);

        $locationProvider.html5Mode(true);
        $urlRouterProvider.otherwise('/');
    }
]);