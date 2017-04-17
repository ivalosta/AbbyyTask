/// <reference path="angular.min.js" />

var app = angular.module("abbyyTaskApp", []);
app.controller("HomeCtrl",
[
    "$scope", "$http", function($scope, $http) {

        $scope.Form = new Object();
        $scope.Form.Concepts = [];
        $scope.newConcept = new Object();
        $scope.messages = [];

        $http({
                method: "GET",
                url: "/Home/GetCardinalities"
            })
            .success(function(data, status, headers, config) {
                $scope.cardinalities = data;
            }).error(function(data, status, headers, config) {
                console.log(error);
            });

        $http({
                method: "GET",
                url: "/Home/GetTypes"
            })
            .success(function(data, status, headers, config) {
                $scope.propertyTypes = data;
            }).error(function(data, status, headers, config) {
                console.log(error);
            });


        $scope.addConcept = function() {
            if ($scope.Form.Concepts.filter(e => e.Name === $scope.newConcept.Name).length < 1
                && $scope.newConcept.Name
                && $scope.newConcept.Cardinality) {
                $scope.newConcept.Properties = [];
                $scope.Form.Concepts.push($scope.newConcept);
                $scope.newConcept = new Object();
            }
        };

        $scope.removeConcept = function(name) {
            var index = -1;
            var comArr = eval($scope.Form.Concepts);
            for (var i = 0; i < comArr.length; i++) {
                if (comArr[i].Name === name) {
                    index = i;
                    break;
                }
            }
            if (index === -1) {
            }
            $scope.Form.Concepts.splice(index, 1);
        };

        $scope.addProperty = function(concept) {
            if (concept.Properties.filter(e => e.Name === concept.newProperty.Name).length < 1
                && concept.newProperty.Name
                && concept.newProperty.Cardinality
                && concept.newProperty.Type) {
                concept.Properties.push(concept.newProperty);
                concept.newProperty = new Object();
            }
        };

        $scope.removeProperty = function(concept, name) {
            var index = -1;
            var comArr = eval(concept.Properties);
            for (var i = 0; i < comArr.length; i++) {
                if (comArr[i].Name === name) {
                    index = i;
                    break;
                }
            }
            if (index === -1) {
            }
            concept.Properties.splice(index, 1);
        };


        $scope.clearMessages = function() {
            $scope.messages = [];
            $scope.showMessages = false;
        }


        $scope.getJson = function() {
            $http({
                    method: "POST",
                    url: "/Home/GetJson",
                    data: $scope.Form
                })
                .success(function(data, status, headers, config) {
                    $scope.messages.unshift(JSON.stringify(data, undefined, 2));
                }).error(function(data, status, headers, config) {
                    console.log(error);
                });
        }
    }
]);