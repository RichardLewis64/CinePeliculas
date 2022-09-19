function validate() {
    var username = document.getElementById('username').value;
    var password = document.getElementById('pass').value;
        
      if (username === "" || username === null) {
        intensify($('#userLabel'));
                    return false;
      }
      
      if (password === "" || password === null) {
                 intensify($('#passLabel'));
                    return false;
      }
    }
    
    function intensify(intense) {
        intense.addClass('animated shakeit').delay(6000).queue(function(){
                        intense.removeClass('animated shakeit').dequeue();
                    });
    }
    
    function clicked() {
        $('button').addClass('clicked').delay(200).queue(function(){
            $('button').removeClass('clicked').dequeue();
        });
    }
    
    var submit = document.getElementById('submit');
    submit.addEventListener('click', clicked);
    submit.addEventListener('click', validate);