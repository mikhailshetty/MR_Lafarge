<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="FirstPage.aspx.cs" Inherits="FirstPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" Runat="Server">
    <!-- Marketing messaging and featurettes
    ================================================== -->
    <!-- Wrap the rest of the page in another container to center all the content. -->
    <br /><br /><br /><br /><br /><br /><br /><br />
    <form runat ="server">
    <div class="container marketing">

      <!-- Three columns of text below the carousel -->
      <div class="row">
        <div class="col-lg-4">
          <asp:ImageButton runat="server" CssClass="img-circle" id="Circle1" ImageUrl="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" OnMouseOver="src='images/Circle-Arrows.gif';" OnMouseOut="src='data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw=='" style="width: 140px; height: 140px;" OnClick="Circle1_Click"/>
          <h2>Login Tracker</h2>
          <p>View the Login Tracker - Sign In and Sign Out Sheet. Manager authetication required.</p>
          <br />
            <p><a class="btn btn-default" href="http://localhost:51045/LoginPage.aspx" role="button">Login &raquo;</a></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-4">
          <asp:ImageButton runat="server" CssClass="img-circle" id="Circle2" ImageUrl="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" OnMouseOver="src='images/Circle-Arrows.gif';" OnMouseOut="src='data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw=='" style="width: 140px; height: 140px;" OnClick="Circle2_Click"/>          
            <h2>Orientation</h2>
          <p>Provide Employee Orientation. Facilitator Authetication is required.</p>
          <br />
            <p><a class="btn btn-default" href="http://localhost:51045/FacilitatorApproval.aspx" role="button">Orientation &raquo;</a></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-4">
          <asp:ImageButton runat="server" CssClass="img-circle" id="Circle3" ImageUrl="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" OnMouseOver="src='images/Circle-Arrows.gif';" OnMouseOut="src='data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw=='" style="width: 140px; height: 140px;" OnClick="Circle3_Click"/>
          <h2>Edit Options</h2>
          <p>Edit existing employees or Add new employees. Manager Authetication required.</p>
          <br />
            <p><a class="btn btn-default" href="http://localhost:51045/EditPage.aspx" role="button">Edit &raquo;</a></p>
        </div><!-- /.col-lg-4 -->
      </div><!-- /.row -->


     <%-- <!-- START THE FEATURETTES -->

      <hr class="featurette-divider">

      <div class="row featurette">
        <div class="col-md-7">
          <h2 class="featurette-heading">First featurette heading. <span class="text-muted">It'll blow your mind.</span></h2>
          <p class="lead">Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
        </div>
        <div class="col-md-5">
          <img class="featurette-image img-responsive" data-src="holder.js/500x500/auto" alt="Generic placeholder image">
        </div>
      </div>

      <hr class="featurette-divider">

      <div class="row featurette">
        <div class="col-md-5">
          <img class="featurette-image img-responsive" data-src="holder.js/500x500/auto" alt="Generic placeholder image">
        </div>
        <div class="col-md-7">
          <h2 class="featurette-heading">Oh yeah, it's that good. <span class="text-muted">See for yourself.</span></h2>
          <p class="lead">Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
        </div>
      </div>

      <hr class="featurette-divider">

      <div class="row featurette">
        <div class="col-md-7">
          <h2 class="featurette-heading">And lastly, this one. <span class="text-muted">Checkmate.</span></h2>
          <p class="lead">Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
        </div>
        <div class="col-md-5">
          <img class="featurette-image img-responsive" data-src="holder.js/500x500/auto" alt="Generic placeholder image">
        </div>
      </div>

      <hr class="featurette-divider">

      <!-- /END THE FEATURETTES -->--%>

        <br /><br /><br /><br /><br />
      <!-- FOOTER -->
      <footer>
        <p class="pull-right"><a href="#">Back to top</a></p>
        <p>&copy; Lafarge 2014. &middot; <%--<a href="#">Privacy</a> &middot;--%> <a href="http://www.lafarge.com/wps/portal/8_9-Mentions_legales">Terms</a></p>
      </footer>
    </div><!-- /.container -->
        </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" Runat="Server">
</asp:Content>

