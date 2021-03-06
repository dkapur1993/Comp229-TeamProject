﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Library.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Comp229_TeamProject.Services" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-2 margin">
        <div class="container text-center">

            <span class="glyphicon glyphicon-user"></span>&nbsp; The Librarian.<br />
            <span class="glyphicon glyphicon-map-marker"></span>&nbsp; 3211, Hypothetical Street,<br />
            &nbsp;&nbsp; Toronto, Ontario<br />
            &nbsp;&nbsp; CANADA.<br />
            <span class="glyphicon glyphicon-phone"></span>&nbsp; +1 (647)-XXX-XXXX
            <br />
            <span class="glyphicon glyphicon-envelope"></span>&nbsp; contact@dslibrary.ca
            <br />
        </div>
    </div>


    <%-- Google Maps --%>

    <div id="map" style="height: 400px"></div>

    <%-- Google API --%>

    <script>
        initMap();
    </script>

    <script async="async" defer="defer"
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBPv5FLg4cIeRJETnebK6pm9fFZcj4YYsk&callback=initMap">
    </script>
</asp:Content>

