<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Eliminar</title>
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div>
        <form action="/Video/Eliminar" method="post">
            <fieldset>
                <legend>Eliminar video</legend>

                <label for="idvideo">idvideo</label>
                <input type="text" name="idvideo"/>

                <input type="submit" name="Eliminar video"/>
            </fieldset>
        </form>
    </div>
</body>
</html>

