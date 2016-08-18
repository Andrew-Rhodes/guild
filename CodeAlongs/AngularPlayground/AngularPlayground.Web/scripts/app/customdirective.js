var app = angular.module('movieApp', ['ngRoute']);

app.directive('ngStarRating',
    function () {
        // directives return an object
        return {
            restrict: 'EA',             // declare as element or attribute
            templateUrl: '/Content/app/templates/starRating.html',
            scope: {
                rating: '=rating',      // two-way binding
                maxRatingVal: '@',         // attribute
                label: '@',             // attribute
                click: "&",             // function
                mouseHover: "&",        // function
                mouseLeave: "&"         // function
            },
            compile: function(element, attrs) {
                // if they don't provide a maxRating attribute, default it to 5
                if (!attrs.maxRatingVal || Number(attrs.maxRatingVal) <= 0) {
                    attrs.maxRatingVal = '5';
                }

                if (!attrs.label) {
                    attrs.label = 'Rating';
                }
            },
            controller: function ($scope, $element, $attrs) {
                // array for the number of items to draw
                $scope.maxRatings = [];

                // initialization of rating variables
                // rating holds the clicked value
                // _rating holds the current value
                $scope.rating = $scope._rating = 0;

                // adding a variable to hold the hover value
                $scope.hoverValue = 0;

                // add an element for each rating
                // (used in ng-repeat in the template)
                for (var i = 1; i <= $scope.maxRatingVal; i++) {
                    $scope.maxRatings.push({});
                }

                // if the rating is less than the index (position) of the star
                // we should display an empty star
                // otherwise display a filled star
                $scope.getStarPath = function(index) {
                    if ($scope._rating + $scope.hoverValue <= index) {
                        return "/Content/app/images/star-empty-24.png";
                    }

                    return "/Content/app/images/star-full-24.png";
                };

                $scope.starClick = function (starValue) {
                    // set the rating
                    $scope.rating = $scope._rating = starValue;

                    // clear the hover value
                    $scope.hoverValue = 0;

                    $scope.click({ starValue: starValue }); // send to parent
                };

                $scope.getRating = function() {
                    if ($scope.rating && $scope.rating !== 0) {
                        return $attrs.label + ": " + $scope.rating;
                    }

                    return $attrs.label;
                };

                $scope.starMouseHover = function (starValue) {
                    $scope._rating = 0;

                    // set the hover value
                    $scope.hoverValue = starValue;

                    $scope.mouseHover({
                        starValue: starValue
                    });
                };

                $scope.starMouseLeave = function (starValue) {
                    $scope._rating = $scope.rating;

                    // clear the hover value
                    $scope.hoverValue = 0;

                    $scope.mouseLeave({
                        starValue: starValue
                    });
                };

            }
        };
    });