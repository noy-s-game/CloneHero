<p class="has-line-data" data-line-start="0" data-line-end="3">This is a submition for Weekly Assignment 2.<br>
Available at: <a href="https://github.com/gamedev-at-ariel/gamedev-5782/blob/master/04-unity-triggers/homework.pdf">https://github.com/gamedev-at-ariel/gamedev-5782/blob/master/04-unity-triggers/homework.pdf</a><br>
Submission Patricipant: Noy Ohana</p>
<p class="has-line-data" data-line-start="4" data-line-end="5">This project is an implementation of the second part of the Assignment (I choose to implement a Guitar Hero-like clone):</p>
<p class="has-line-data" data-line-start="6" data-line-end="7">The Implementation:</p>
<ol>
<li class="has-line-data" data-line-start="7" data-line-end="8">First there is an “Activator” Prefab which is used to catch the note that falls from above (There are 5 of them grouped under Activators game object where each of them offers a collider to be an actual physical object)</li>
<li class="has-line-data" data-line-start="8" data-line-end="10">Then there is a “Note” script which make notes fall into the right activatoror at set speed which is changable by the editor in the noteSpawner object.</li>
</ol>
<p class="has-line-data" data-line-start="10" data-line-end="11">How The game works:</p>
<ol>
<li class="has-line-data" data-line-start="11" data-line-end="12">The Spawner spawns the random prefab under the editor given values (Lower\Upper Spawn Limit) and the spawner is given all the gameObjects (Colored Notes in our case that are needed)</li>
<li class="has-line-data" data-line-start="12" data-line-end="13">In the right time when OnTrigger2D happends or collides and the right key is pressed (Z,X,C,V,B) for each colorthe note dissaper and the appropriate activator becomes black for editor pre-defined time.</li>
</ol>