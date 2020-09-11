# Set up for serving from HublSoft.Task.Monitor



## Create and link the build

The `build` script documented below will produce a build folder containing the static scripts.
In order to serve this folder from the ASP.NET MVC application, create a symlink from its `wwwroot` folder named `client`

For example, here's how to do it using [mklink](https://docs.microsoft.com/en-us/windows-server/administration/windows-commands/mklink) from Windows Command Prompt:
```cmd
cd idea\Hublsoft.Task.Web\wwwroot
mklink /D ..\..\task-web-client\build client
```


## Updating the Razor view to use a built script

Running the build script will create a file called index.html from which you can copy the necessary stylesheet `link` and javascript `script` tags for embedding into the Razor views.

For example, the stylesheet link tag might look like this:

```html
<link href="/client/static/css/main.27fd15f6.chunk.css" rel="stylesheet">
```

and the script tags might look like this:

```html
<script>!function (e) { function t(t) { for (var n, l, i = t[0], a = t[1], f = t[2], p = 0, s = []; p < i.length; p++)l = i[p], Object.prototype.hasOwnProperty.call(o, l) && o[l] && s.push(o[l][0]), o[l] = 0; for (n in a) Object.prototype.hasOwnProperty.call(a, n) && (e[n] = a[n]); for (c && c(t); s.length;)s.shift()(); return u.push.apply(u, f || []), r() } function r() { for (var e, t = 0; t < u.length; t++) { for (var r = u[t], n = !0, i = 1; i < r.length; i++) { var a = r[i]; 0 !== o[a] && (n = !1) } n && (u.splice(t--, 1), e = l(l.s = r[0])) } return e } var n = {}, o = { 1: 0 }, u = []; function l(t) { if (n[t]) return n[t].exports; var r = n[t] = { i: t, l: !1, exports: {} }; return e[t].call(r.exports, r, r.exports, l), r.l = !0, r.exports } l.m = e, l.c = n, l.d = function (e, t, r) { l.o(e, t) || Object.defineProperty(e, t, { enumerable: !0, get: r }) }, l.r = function (e) { "undefined" != typeof Symbol && Symbol.toStringTag && Object.defineProperty(e, Symbol.toStringTag, { value: "Module" }), Object.defineProperty(e, "__esModule", { value: !0 }) }, l.t = function (e, t) { if (1 & t && (e = l(e)), 8 & t) return e; if (4 & t && "object" == typeof e && e && e.__esModule) return e; var r = Object.create(null); if (l.r(r), Object.defineProperty(r, "default", { enumerable: !0, value: e }), 2 & t && "string" != typeof e) for (var n in e) l.d(r, n, function (t) { return e[t] }.bind(null, n)); return r }, l.n = function (e) { var t = e && e.__esModule ? function () { return e.default } : function () { return e }; return l.d(t, "a", t), t }, l.o = function (e, t) { return Object.prototype.hasOwnProperty.call(e, t) }, l.p = "/"; var i = this["webpackJsonptask-web-client"] = this["webpackJsonptask-web-client"] || [], a = i.push.bind(i); i.push = t, i = i.slice(); for (var f = 0; f < i.length; f++)t(i[f]); var c = a; r() }([])</script>
<script src="/client/static/js/2.23f987c2.chunk.js"></script>
<script src="/client/static/js/main.2cdae192.chunk.js"></script>
```



# Development

Local development can be conducted using the built-in development server which is launched using the `start` script below.

In the project directory, you can run:

## `yarn start`

Runs the app in the development mode.<br />
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

The page will reload if you make edits.<br />
You will also see any lint errors in the console.

## `yarn test`

Launches the test runner in the interactive watch mode.<br />
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

## `yarn build`

Builds the app for production to the `build` folder.<br />
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.<br />
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.

## More information
This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).