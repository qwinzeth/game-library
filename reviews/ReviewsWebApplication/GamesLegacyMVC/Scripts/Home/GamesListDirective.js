GamesLegacyMVC = window.GamesLegacyMVC || {};
GamesLegacyMVC.GamesListDirective = function GamesListDirective() {
    return {
        GamesListDirective: function GamesListDirective() {
            return {
                restrict: 'E',
                transclude: true,
                scope: {},
                controller: GamesLegacyMVC.IndexController().GamesListController,
                templateUrl: GamesLegacyMVC.URLMap.GamesListTemplate,
                replace: true
            };
        }
    };
};

angular.module('components', [])
    .directive('gameslist', GamesLegacyMVC.GamesListDirective().GamesListDirective);
