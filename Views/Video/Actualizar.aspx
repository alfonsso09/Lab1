<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Actualizar</title>
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div>
        <form action="/Video/Actualizar" method="post">
            <fieldset>
            <legend>Actualizar datos de video</legend>

            <label for="idvideo">idvideo</label>
            <input type="text" name="idvideo" />
            <hr />

            <label for="titulo">titulo</label>
            <input type="text" name="titulo"/>

            <label for="repro">Reproducciones</label>
            <input type="text" name="repro"/>

            <label for="url">url</label>
            <input type="text" name="url" />

            <input type="submit" name="Actualizar video"/>
            </fieldset>
        </form>
    </div>
</body>
</html>
