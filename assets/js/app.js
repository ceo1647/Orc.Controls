var doNotLoad=false;$(document).ready(function(){if(window.attachEvent){window.attachEvent("onmessage",OnLoadPage,false)}else{window.addEventListener("message",OnLoadPage,false)}$(window).hashchange(function(){if(!doNotLoad){navigationController.setDocSite(window.location.hash.slice(1))}else{doNotLoad=false;navigationController.selectNode("node-"+window.location.hash.slice(1))}});$("body").layout({center__maskIframesOnResize:true,defaults:{paneClass:"ui-outer",resizerClass:"ui-outer-resizer",closable:false,resizable:false},north:{size:131},west:{resizable:true,size:350}});$("#content").load(function(){navigationController.hideLoader()});navigationController=new NavigationController();searchController=new SearchController("#searchInput","#searchResults",searchIndex)});function OnLoadPage(a){if(a.data!=null){if(window.location.hash!=a.data&&a.data!="showLoader"&&a.data!="hideLoader"){doNotLoad=true;window.location.hash=a.data}else{if(a.data=="showLoader"){navigationController.showLoader()}else{if(a.data=="hideLoader"){navigationController.hideLoader()}}}}};var SearchController=function(a,b,c){this._searchIndex=c;this._resultsDivId=b;this._resultsFound=false;this.init(a)};SearchController.prototype={init:function(a){var b=this;$(a).on("input",function(c){b.search(this.value)});$(a).on("focus",function(c){b.showResults()});$(a).on("blur",function(c){b.hideResults()})},search:function(c){var b=this;b._resultsFound=false;var a=$(this._resultsDivId);a.empty();if(c!=""){a.append("<ul>");$.each(this._searchIndex,function(d,e){if(e.Name.toLowerCase().indexOf(c.toLowerCase())>-1){a.append('<li><a href="'+e.Url+'">'+e.Name+'<p class="result-item-footer">'+e.Type+"</p></a></li>");b._resultsFound=true}});a.append("</ul>");if(!b._resultsFound){a.append('<p class="no-results">No results found</p>')}this.showResults()}else{this.hideResults()}},showResults:function(){if(this._resultsFound){$(this._resultsDivId).slideDown()}},hideResults:function(){$(this._resultsDivId).slideUp()}};var NavigationController=function(){this._title=$("#subtitle p");this.init()};NavigationController.prototype={init:function(){var a=this;$("#navigation").jstree();$("#navigation").bind("select_node.jstree",function(d,c){var f=c.instance.get_node(c.node,true).children("a").attr("href");if(f!="#"&&!doNotLoad){a._title.html(c.node.text);document.location=f}else{if(f!="#"){a._title.html(c.node.text)}}doNotLoad=false;if(c.node.parent!="#"){c.instance.open_node(c.node)}return false});var b=window.location.hash.slice(1);if(b==""){b="home"}this.setDocSite(b)},setDocSite:function(a){this.showLoader();if(a=="home"){this.selectNode("node-home");$("#content").attr("src","article/home.html")}else{if(a!=""){var b=a.split("?");if(b.length==2){a=b[0]+".html#"+b[1]}else{a=b[0]+".html"}doNotLoad=true;this.selectNode("node-"+b[0]);$("#content").attr("src",a)}}},selectNode:function(a){$("#navigation").jstree("deselect_all");$("#navigation").jstree("select_node",a)},showLoader:function(){$("#loader").css("top",$("#content").css("top"));$("#loader").css("left",$("#content").css("left"));$("#loader").css("height",$("#content").css("height"));$("#loader").css("width",$("#content").css("width"));$("#loader i").css("margin-top",(parseInt($("#loader").css("height"),10)/2)+"px");$("#loader").show()},hideLoader:function(){$("#loader").fadeOut(500)}};