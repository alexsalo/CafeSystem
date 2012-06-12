/// <reference path="http://localhost:13505/Scripts/jquery-1.4.1.js" />
$(function () {
    $("#food_cat_select").change(function () {
        var food_cat_id = $("#food_cat_select option:selected").val();
        var food_cat_text = $("#food_cat_select option:selected").text();

        $.post("Menu/getRecipes", { id: food_cat_id }, function (response) {
            var i;
            for (i=0; i<response.length; i++) 
                $("<div>").html(response[i].name);                
        
        });
    });
});
