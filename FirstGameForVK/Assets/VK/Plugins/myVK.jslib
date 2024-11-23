mergeInto(LibraryManager.library, {

	UnityPluginRequestJs : function (value) {
    		FromUnityToJs (value);
	},

	UnityPluginRequestAvatar : function () {
    		GetDataPlayer();
	},

});