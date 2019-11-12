GamesLegacyMVC = window.GamesLegacyMVC || {};
GamesLegacyMVC.Index = function Index() {
    return {
        IndexController: function ($scope) {
            $scope.error = "";
        }
    };
};

angular.module('app', ['components'])
    .controller('GamesList', GamesLegacyMVC.GamesList().GamesListController)
    .controller('Index', GamesLegacyMVC.Index().IndexController);
