/*
 * 
 * 
 * 
 * 
 * ViewData["Msg"] = "Hello";
 * Key             =  Value
 * ViewData : (Dictionary [Key , Value])
 * Use it If i Want Send Extra Data With Model in The Same Action
 * 
 * 
 * ViewData Problem :
 * 1. Casting because it's Object
 * 2. Null Reference Exceptions
 * 3. ViewData Keys Confusion
 * 
 * 
 * 
 * 
 * ViewBag : Dynamic
 * Get From ViewData => ViewBad.Msg;             in View
 * Set in ViewData   => ViewBad.Msg = "Ahmed";   in Action
 * Without Casting All Casting in RunTime
 * ViewBag See Only ViewData in It's Action Can't Read ViewData Form other Action
 * 
 * 
 * TempData : Can Be Session or Cookies
 * Used to pass data from the current request to the next request
 * The value of TempData persists until it is read or until the current user's session times out.
 * Can Use it in Any Controller Because we read From Cookies But Must Set it Brfore Get
 * 
 *
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * */