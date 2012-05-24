<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CafeASPMVC.Models.recipe>" %>
<%@ Import Namespace="CafeASPMVC.Models" %>

<script src="http://localhost:13505/Scripts/jquery-1.4.1.js" type="text/javascript"></script>


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
            <br /><br /><br /><br />
            <h3>
                <a href="index.html">Home</a></h3>
            <h3>
                <a href=menu>Menu</a></h3>
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
            <p align="right">The current datatime is: <%: ViewData["CurrentTime"] %></p>
            <center>
                <h1>
                    Eat and Joy</h1>
            </center>
            <div class="offset-by-one">
                <div class="twelve columns">
                    <div>
                    
                        Recipe #1 is <%: ViewData["recipeName"]%>
                    </div>
                    <div>
                       
                        <select id="food_cat_select">
                            <%List<food_category> fclist = 
                                  (new DoWork()).getFoodCategory();%>
                            <%for (int i = 0; i < fclist.Count; i++)
                              { %>
                                <option value="<%=fclist[i].food_category_id%>"><%=fclist[i].name%>
                                </option>
                            <%} %>
                        </select>
                        <script type="text/javascript">
                            $(document).ready(function () {
                                $("#food_cat_select").change(function () {                                    
                                    alert($("#food_cat_select option:selected").text());
                                });

                            });
                        </script>


                        <div class="pane">
                            <img class="delete" alt="df"/>
                            <h2>Some Head</h2> 
                            <p> sfhjksdhfsdhflsdhfhsdfsdfsdjflsdfkjs
                            sdfksdjflksdjfklj
                            sdfklsdjksjgls
                            sdgilsdjgljsdig</p>
                        </div>
                        <script type="text/javascript">
                            $(document).ready(function () {
                                $(".pane .delete").click(function () {
                                    $(this).parents(".pane").animate({ opacity: "hide" }, "slow");
                                });

                            });
                        </script>
                        <!-- 
                        select a food_category:
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                            DataSourceID="FoodCategoryEntityDataSource1" DataTextField="name" 
                            DataValueField="food_category_id">
                        </asp:DropDownList>

                        <asp:EntityDataSource ID="FoodCategoryEntityDataSource1" runat="server" 
                            ConnectionString="name=enjCafeEntities" DefaultContainerName="enjCafeEntities" 
                            EnableFlattening="False" EntitySetName="food_category">
                        </asp:EntityDataSource>

                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="recipe_id" DataSourceID="RecipeEntityDataSource2" 
                            Width="461px">
                            <Columns>
                                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                <asp:BoundField DataField="description" HeaderText="description" 
                                    SortExpression="description" />
                                <asp:BoundField DataField="totalcost" HeaderText="totalcost" 
                                    SortExpression="totalcost" />
                            </Columns>
                        </asp:GridView>

                        <asp:EntityDataSource ID="RecipeEntityDataSource2" runat="server" 
                            AutoGenerateWhereClause="True" ConnectionString="name=enjCafeEntities" 
                            DefaultContainerName="enjCafeEntities" EnableDelete="True" 
                            EnableFlattening="False" EnableInsert="True" EnableUpdate="True" 
                            EntitySetName="recipe" Where="" EntityTypeFilter="" Select="">
                            <WhereParameters>
                                <asp:ControlParameter ControlID="DropDownList1" Name="food_category_id" 
                                    PropertyName="SelectedValue" Type="Int32" />
                            </WhereParameters>
                        </asp:EntityDataSource>
                        -->
                    </div>
                  
                </div>
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

