GamesLegacyMVC = window.GamesLegacyMVC || {};
GamesLegacyMVC.IndexController = function IndexController() {
    return {
        GamesListController: function GamesListController($scope, $http) {
            function getGamesSuccess(response) {
                $scope.games = response.data.games;
            }

            function getGamesError(response) {
                console.log(response);
            }

            $scope.games = [{ Title: "Loading..." }];
            $http.get(GamesLegacyMVC.URLMap.GetGames, {}).then(getGamesSuccess, getGamesError);
        }
    };
};

angular.module('app', ['components'])
    .controller('GamesList', GamesLegacyMVC.IndexController().GamesListController);
