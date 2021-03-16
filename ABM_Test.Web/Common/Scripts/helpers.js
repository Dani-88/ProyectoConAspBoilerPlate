var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('ABM_Test');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);