# FoodRecipes
  This prototype is hosted at:  <a href="https://smartblockchain2.github.io/FoodRecipeApi/"   target="_blank">Recipe Lookup</a>
  
  Display Recipes based on user queries against Edamam Recipe API.  

## Purpose
  This was designed as a proof of concept, for displaying Recipes online, using Javascript, jQuery, and Ajax calls against the Edamam Recipe API.
  
## Workflow
  The user is presented with a Recipe Search Page (RSP) as the landing page.
    1)  The landing page displays a search control.  
    2)  The user types in the name of a food group (e.g., pie, cherry pie, cake, chicken, rice, etc...).
    3)  An ajax requested is made to the Edamam Recipe API.  
    4)  Edamam API Responds.
    5)  The Json response is parsed and rendered on the same view.
      
 Note:  The Edamam API version used is the free version.  It only allows for five requests per minute.
 
 Notes for future:  
    1)  Design user presentation layer.
    2)  Add Slack Community to the site.
    3)  Provide additional features (to be determine) for people that enroll at the site.  Features can include the items listed below.
        a)  Ability to join in Slack community.
        b)  Greater number of pulls.
        c)  Newsletter.
        
    4)  Click Advertisements centered around food preparation goods and services.
    
