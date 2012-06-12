<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CafeASPMVC.Models.recipe>" %>

<%@ Import Namespace="CafeASPMVC.Models" %>
<script src="http://code.jquery.com/jquery-1.7.2.min.js"></script>
<script src="../../Scripts/tabs.js"></script>
<script src="../../Scripts/fill_food_category.js" type="text/javascript"></script>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Index</title>
    <link rel="stylesheet" href="../../Content/base.css">
    <link rel="stylesheet" href="../../Content/skeleton.css">
    <link rel="stylesheet" href="../../Content/layout.css">
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="sixteen columns" id="footer">
            <h1 class="remove-bottom" style="margin-top: 40px">
                Welcome to E'n'J Cafe
            </h1>
            <h5>
                Designed by Alex Salo, Version 1.1</h5>
            <hr />
        </div>
        <div class="two columns" id="navigate-panel">
            <br />
            <br />
            <br />
            <br />
            <h3>
                <a href="index.html">Home</a></h3>
            <h3>
                <a href="menu">Menu</a></h3>
            <h3>
                <a href="//www.google.com">Events</a></h3>
            <h3>
                <a href="location.html">Location</a></h3>
            <h3>
                Contacts</h3>
            <h3>
                Career</h3>
            <h3>
                About</h3>
        </div>
        <div class="fourteen columns" id="content-main-info">
            <div class="offset-by-one">
                <p align="right">
                    The current datatime is:
                    <%: ViewData["CurrentTime"] %></p>
                <center>
                    <h1>
                        Eat and Joy</h1>
                </center>
                <select id="food_cat_select">
                    <%List<food_category> fclist =
                                  DoWork.Instanse.getFoodCategory();%>
                    <%for (int i = 0; i < fclist.Count; i++)
                      { %>
                    <option value="<%=fclist[i].food_category_id%>">
                        <%=fclist[i].name%>
                    </option>
                    <%} %>
                </select>
                <div id="panelCart">                    
                    <p>
                        empty list</p>
                </div>
                <div align="center" class="btn-slide active" id="slidebtn">
                    Show Cart
                </div>
                <br />
                <ul class="tabs">
                    <!-- Give href an ID value of corresponding "tabs-content" <li>'s -->
                    <li><a class="active" href="#Italian">Italian</a></li>
                    <li><a href="#BBQ">BBQ</a></li>
                    <li><a href="#Asian">Asian</a></li>
                    <li><a href="#Mexican">Mexican</a></li>
                </ul>
                <!-- Standard <ul> with class of "tabs-content" -->
                <ul class="tabs-content" id="food_cat_tabs">
                    <!-- Give ID that matches HREF of above anchors -->
                    <li class="active" id="Italian">
                        <div class="twelve columns" id="ItalianRecipes">
                            <p>
                                dfdfdfdfd</p>
                            <%List<recipe> ItalianRecipeList = DoWork.Instanse.getRecipesListByCategory(1); %>
                            <%for (int i = 0; i < ItalianRecipeList.Count; i++)
                              { %>
                            <div class="five columns" id="recipe_<%=ItalianRecipeList[i].name%>">
                                <div class="pane">
                                    <img src="../../images/controls/close_btn.png" align="right" class="delete" alt="df" />
                                    <h2>
                                        <%=ItalianRecipeList[i].name%></h2>
                                    <p>
                                        <%=ItalianRecipeList[i].description %>
                                    </p>
                                </div>
                            </div>
                            <%} %>
                        </div>
                    </li>
                    <li id="BBQ">
                        <div class="twelve columns" id="BBQRecipes">
                            <%List<recipe> BBQRecipeList = DoWork.Instanse.getRecipesListByCategory(2); %>
                            <%for (int i = 0; i < BBQRecipeList.Count; i++)
                              { %>
                            <div class="five columns" id="recipe_<%=BBQRecipeList[i].name%>">
                                <div class="pane">
                                    <img src="../../images/controls/close_btn.png" align="right" class="delete" alt="df" />
                                    <h2>
                                        <%=BBQRecipeList[i].name%></h2>
                                </div>
                            </div>
                            <%} %>
                        </div>
                    </li>
                    <li id="Asian">
                        <div class="twelve columns" id="AsianRecipes">
                            <%List<recipe> AsianRecipeList = DoWork.Instanse.getRecipesListByCategory(3); %>
                            <%for (int i = 0; i < AsianRecipeList.Count; i++)
                              { %>
                            <div class="five columns" id="recipe_<%=AsianRecipeList[i].name%>">
                                <div class="pane">
                                    <img src="../../images/controls/close_btn.png" align="right" class="delete" alt="df" />
                                    <h2>
                                        <%=AsianRecipeList[i].name%></h2>
                                </div>
                            </div>
                            <%} %>
                        </div>
                    </li>
                    <li id="Mexican">
                        <div class="twelve columns" id="MexicanRecipes">
                            <%List<recipe> MexicanRecipeList = DoWork.Instanse.getRecipesListByCategory(4); %>
                            <%for (int i = 0; i < MexicanRecipeList.Count; i++)
                              { %>
                            <div class="five columns" id="recipe_<%=MexicanRecipeList[i].name%>">
                                <div class="pane">
                                    <img src="../../images/controls/close_btn.png" align="right" class="delete" alt="df" />
                                    <h2>
                                        <%=MexicanRecipeList[i].name%></h2>
                                </div>
                            </div>
                            <%} %>
                        </div>
                    </li>
                </ul>
                <script type="text/javascript">
                    $(document).ready(function () {
                        $(".btn-slide").click(function () {
                            $("#panelCart").slideToggle("slow");
                            $(this).toggleClass("active");
                        });
                    });
                </script>
                <script type="text/javascript">
                    $(document).ready(function () {
                        $("#food_cat_select").change(function () {
                            alert($("#food_cat_select option:selected").text());
                        });

                    });
                </script>
                <script type="text/javascript">
                    $(document).ready(function () {
                        $(".pane .delete").click(function () {
                            $(this).parents(".pane").animate({ opacity: "hide" }, "slow");
                        });
                    });
                </script>
            </div>
        </div>
        <!--<div class="one-third column">
			<h3>Docs &amp; Support</h3>
			<p>The easiest way to really get started with Skeleton is to check out the full docs and info at <a href="http://www.getskeleton.com">www.getskeleton.com.</a>. Skeleton is also open-source and has a <a href="https://github.com/dhgamache/skeleton">project on git</a>, so check that out if you want to report bugs or create a pull request. If you have any questions, thoughts, concerns or feedback, please don't hesitate to email me at <a href="mailto:hi@getskeleton.com">hi@getskeleton.com</a>.</p>
		</div>-->
    </div>
    <!-- container -->
    </form>
</body>
</html>
