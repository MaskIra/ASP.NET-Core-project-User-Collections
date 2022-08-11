### ASP.NET Core MVC + MSSQL, MongoDB (+Bootstrap)
 * Unauthenticated users are not allowed to create collections and items
 * The administrator sees each user page and each collection as its creator-owner (for example, he can edit or create a new collection on behalf of the user from his page or add an item, etc.)
 * Only the owner or admin can manage the collection (edit/add/delete)
 * Sign in, sign up
 * Each user has a page on which he manages the list of his collections (adding / changing / deleting), a collection page (a table with the ability to create / delete / edit an item). For the admin, this is the page of all collections
 * Collection (by MSSQL): name, short description (markdown), theme from a fixed set, optional image (stored in the cloud, loaded by drag-n-drop)
 * The collection has the ability to specify the fields that each item (by MongoDB) will have in it. A text field is a field with markdown formatting.
 * Localization: eng, rus
 * Decoration: light, dark
