import { ActionTypes } from './action-types';

const initialState: PostState = {
    posts: []
}

const reducer = (
    state: PostState = initialState,
    action: PostAction
): PostState => {
    switch (action.type) {
        case ActionTypes.ADD_POST: return state;
        case ActionTypes.GET_ALL_POSTS:
            state.posts.length = 0;
            return {
                ...state,
                posts: state.posts.concat(action.posts)
            };
        default: return state;
    }
}

export default reducer;
