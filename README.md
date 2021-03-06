# CultureDemo

<h3>Localization with English and Spanish</h3>

Easy to include other languages (Add resource files to relevant areas)

<h5>Steps to research:</h5>

- Have a seperate class library for language files to allow to be referenced elsewhere
- <a href="https://marketplace.visualstudio.com/items?itemName=TomEnglert.ResXManager" target="_blank">Resource tool manager</a>

<h5>Localization multi file:</h5>

> One of the localizability best practices is to not reuse translations in different contexts. That's because you want to allow the translator to use different translations for one same piece of English text in different contexts. Why? Because different languages have different rules (e.g. depending on gender, an adjective can take a different form) and also because of context-specific constaints such as space limitations (e.g. a translator may be forced to shorten a string to make it fit somewhere, but shouldn't have to when it's not necessary).
>> For this reason, having one .resx per view is good practice. If you had just one big .resx, it would be hard to determine what view a string goes into (and you'd also be more tempted to reuse strings in different contexts). You'll also typically need a global .resx for the application for anything that is view-independent, which should be rare.
