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