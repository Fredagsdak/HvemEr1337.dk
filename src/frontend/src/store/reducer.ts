import * as actionTypes from './action-types';

const initialState: PostState = {
    posts: []
}

const reducer = (
    state: PostState = initialState,
    action: PostAction
): PostState => {
    switch (action.type) {
        case actionTypes.ADD_POST: {
            const newPost: IPost = {
                message: action.post.message
            };
            return {
                ...state,
                posts: state.posts.concat(newPost)
            };
        };
        default: return state;
    }
}

export default reducer;
