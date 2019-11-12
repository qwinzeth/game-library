GamesLegacyMVC = window.GamesLegacyMVC || {};
GamesLegacyMVC.GamesList = function GamesList() {
    return {
        GamesListDirective: function GamesListDirective() {
            return {
                restrict: 'E',
                transclude: true,
                scope: { error: "=" },
                controller: GamesLegacyMVC.GamesList().GamesListController,
                templateUrl: GamesLegacyMVC.URLMap.GamesListTemplate,
                replace: true
            };
        },

        GamesListController: function GamesListController($scope, $http) {
            function getGamesSuccess(response) {
                $scope.error = "";
                $scope.games = response.data.games;
            }

            function getGamesError(response) {
                $scope.error = "There was an error loading the list of games.";
                $scope.games = [];
            }

            $scope.games = [{ Title: "Loading..." }];
            $http.get(GamesLegacyMVC.URLMap.GetGames, {}).then(getGamesSuccess, getGamesError);
        }
    };
};

angular.module('components', [])
    .directive('gameslist', GamesLegacyMVC.GamesList().GamesListDirective);
